using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftMarket
{
    [HiveEngineContract("nftmarket", "setMarketParams")]
    public class HiveEngineNftMarketSetMarketParamsModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("officialMarket")] public string OfficialMarket { get; }
        [JsonPropertyName("agentCut")] public int AgentCut { get; }
        [JsonPropertyName("minFee")] public int MinFee { get; }

        public HiveEngineNftMarketSetMarketParamsModel(string symbol, string officialMarket, int agentCut, int minFee)
        {
            Symbol = symbol;
            OfficialMarket = officialMarket;
            AgentCut = agentCut;
            MinFee = minFee;
        }
    }
}