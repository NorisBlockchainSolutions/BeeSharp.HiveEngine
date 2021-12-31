using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "updateProductName")]
    public class HiveEngineNftUpdateProductNameModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("productName")] public string ProductName { get; }

        public HiveEngineNftUpdateProductNameModel(string symbol, string productName)
        {
            Symbol = symbol;
            ProductName = productName;
        }
    }
}