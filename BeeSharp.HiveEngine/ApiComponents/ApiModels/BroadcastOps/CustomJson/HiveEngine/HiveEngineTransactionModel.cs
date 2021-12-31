using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine
{
    [CustomJsonOpId("ssc-mainnet-hive", typeof(ObjectListOrObjectWrapperModel<HiveEngineTransactionModel>))]
    [JsonConverter(typeof(HiveEngineTransactionJsonConverter))]
    public class HiveEngineTransactionModel : CustomJsonOperation
    {
        public HiveEngineTransactionModel(string contractName, string contractAction,
            HiveEngineOperation hiveEngineContractPayloadModel, string? memo = null)
        {
            ContractName = contractName;
            ContractAction = contractAction;
            HiveEngineContractPayloadModel = hiveEngineContractPayloadModel;
            Memo = memo;
        }

        [JsonPropertyName("contractName")] public string ContractName { get; }
        [JsonPropertyName("contractAction")] public string ContractAction { get; }

        [JsonPropertyName("contractPayload")]
        public HiveEngineOperation HiveEngineContractPayloadModel { get; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("memo")] public string? Memo { get; }
    }
}