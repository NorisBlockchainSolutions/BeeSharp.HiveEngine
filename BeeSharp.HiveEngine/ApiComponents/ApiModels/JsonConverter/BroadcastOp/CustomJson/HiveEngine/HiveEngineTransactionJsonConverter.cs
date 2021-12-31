#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.DirectorComponents;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine
{
    public class HiveEngineTransactionJsonConverter : JsonConverter<HiveEngineTransactionModel>
    {
        public override HiveEngineTransactionModel Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            // This json object only contains key value pairs
            // Enter object
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException("Invalid json object!");
            reader.Read();

            var contractName = "";
            var contractAction = "";
            HiveEngineOperation? contractPayload = null;
            dynamic? rawContractPayload = null;
            string? contractMemo = null;

            var director = (HiveEngineContractDirector)DirectorRegistry.GetDirector(typeof(HiveEngineContractDirector));
            while (reader.TokenType == JsonTokenType.PropertyName)
            {
                switch (reader.GetString())
                {
                    case "contractName":
                        reader.Read();
                        contractName = reader.GetString()!;
                        reader.Read();
                        break;
                    case "contractAction":
                        reader.Read();
                        contractAction = reader.GetString()!;
                        reader.Read();
                        break;
                    case "contractPayload":
                        if (string.IsNullOrWhiteSpace(contractName) || string.IsNullOrWhiteSpace(contractAction))
                        {
                            // Since serialization of payload requires both contractName and contractAction, all json
                            // needs to be serialized before determining object type and deserialization
                            rawContractPayload = JsonSerializer.Deserialize<dynamic>(ref reader, options);
                        }
                        else
                        {
                            var payloadType = director.GetStructure(contractName!, contractAction!);
                            if (payloadType is null)
                                throw new JsonException(
                                    $"Unknown hive-engine contract! {contractName} {contractAction}");
                            contractPayload =
                                (HiveEngineOperation)JsonSerializer.Deserialize(ref reader, payloadType, options)!;
                        }

                        reader.Read();
                        break;
                    case "memo":
                        reader.Read();
                        contractMemo = reader.GetString()!;
                        reader.Read();
                        break;
                    default:
                        // Check what information is already known
                        var message = $"Unknown hive engine transaction format: {reader.GetString()}!";
                        if (!string.IsNullOrWhiteSpace(contractName))
                            message += $" contractName: {contractName}";
                        if (!string.IsNullOrWhiteSpace(contractAction))
                            message += $" contractAction: {contractAction}";
                        if (contractPayload is not null)
                            message += $"contractPayload: {JsonSerializer.Serialize(contractPayload)}";
                        else if (rawContractPayload is not null)
                            message += $"contractPayload: {JsonSerializer.Serialize(rawContractPayload)}";
                        if (!string.IsNullOrWhiteSpace(contractMemo))
                            message += $" contractMemo: {contractMemo}";

                        throw new JsonException(message);
                }
            }

            if (contractPayload is null)
            {
                // Deserialize payload
                var payloadType = director.GetStructure(contractName!, contractAction!);
                if (payloadType is null)
                    throw new JsonException($"Unknown hive-engine contract! {contractName} {contractAction}");

                contractPayload = (HiveEngineOperation)JsonSerializer.Deserialize(
                    JsonSerializer.Serialize(rawContractPayload), payloadType, options);
            }

            // Throw event
            director.OnHiveEngineOperationSerialized(contractPayload);

            return new HiveEngineTransactionModel(contractName!, contractAction!, contractPayload!, contractMemo);
        }

        public override void Write(Utf8JsonWriter writer, HiveEngineTransactionModel value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("contractName", value.ContractName);
            writer.WriteString("contractAction", value.ContractAction);
            writer.WritePropertyName("contractPayload");
            // Cast to object before serializing, since HiveEngineOperation is an empty placeholder
            JsonSerializer.Serialize(writer, (object)value.HiveEngineContractPayloadModel, options);
            writer.WriteEndObject();
        }
    }
}