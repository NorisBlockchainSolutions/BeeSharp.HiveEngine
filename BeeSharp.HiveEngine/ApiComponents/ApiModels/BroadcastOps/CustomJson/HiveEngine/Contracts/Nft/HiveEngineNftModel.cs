using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    public class HiveEngineNftModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("ids")] public NumberOrStringModel[] Ids { get; }

        public HiveEngineNftModel(string symbol, NumberOrStringModel[] ids)
        {
            Symbol = symbol;
            Ids = ids;
        }
    }
}