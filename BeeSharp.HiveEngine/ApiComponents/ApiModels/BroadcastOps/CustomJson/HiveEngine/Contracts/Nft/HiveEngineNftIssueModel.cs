using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "issue")]
    public class HiveEngineNftIssueModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("to")] public string To { get; }
        [JsonPropertyName("feeSymbol")] public string FeeSymbol { get; }
        [JsonPropertyName("properties")] public object PropertiesModel { get; }

        public HiveEngineNftIssueModel(string symbol, string to, string feeSymbol,
            object propertiesModel)
        {
            Symbol = symbol;
            To = to;
            FeeSymbol = feeSymbol;
            PropertiesModel = propertiesModel;
        }
    }
}