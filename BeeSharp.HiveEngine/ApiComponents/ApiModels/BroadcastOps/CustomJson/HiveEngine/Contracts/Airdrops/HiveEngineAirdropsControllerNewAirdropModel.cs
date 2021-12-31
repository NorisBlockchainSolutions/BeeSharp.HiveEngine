using System;
using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Airdrops
{
    [HiveEngineContract("airdrops", "newAirdrop")]
    public class HiveEngineAirdropsControllerNewAirdropModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("type")] public string Type { get; }

        [JsonConverter(typeof(ArrayShapedTupleListJsonConverter<string, DecimalOrStringModel>))]
        [JsonPropertyName("list")]
        public Tuple<string, DecimalOrStringModel>[] List { get; }

        public HiveEngineAirdropsControllerNewAirdropModel(string symbol, string type,
            Tuple<string, DecimalOrStringModel>[] list)
        {
            Symbol = symbol;
            Type = type;
            List = list;
        }
    }
}