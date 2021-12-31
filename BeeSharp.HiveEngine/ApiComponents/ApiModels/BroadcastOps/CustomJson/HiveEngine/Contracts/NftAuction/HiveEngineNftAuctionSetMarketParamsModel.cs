using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.NftAuction
{
    [HiveEngineContract("nftauction", "setMarketParams")]
    public class HiveEngineNftAuctionSetMarketParamsModel
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("officialMarket")] public string OfficialMarket { get; }
        [JsonPropertyName("agentCut")] public int AgentCut { get; }
        [JsonPropertyName("minFee")] public int MinFee { get; }

        public HiveEngineNftAuctionSetMarketParamsModel(string symbol, string officialMarket, int agentCut, int minFee)
        {
            Symbol = symbol;
            OfficialMarket = officialMarket;
            AgentCut = agentCut;
            MinFee = minFee;
        }
    }
}