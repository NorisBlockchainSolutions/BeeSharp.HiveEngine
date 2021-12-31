using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "swapTokens")]
    public class HiveEngineMarketPoolsSwapTokensModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("tokenSymbol")] public string TokenSymbol { get; }
        [JsonPropertyName("tokenAmount")] public DecimalOrStringModel TokenAmount { get; }
        [JsonPropertyName("tradeType")] public string TradeType { get; }
        [JsonPropertyName("maxSlippage")] public NumberOrStringModel MaxSlippage { get; }

        public HiveEngineMarketPoolsSwapTokensModel(string tokenPair, string tokenSymbol,
            DecimalOrStringModel tokenAmount, string tradeType, NumberOrStringModel maxSlippage)
        {
            TokenPair = tokenPair;
            TokenSymbol = tokenSymbol;
            TokenAmount = tokenAmount;
            TradeType = tradeType;
            MaxSlippage = maxSlippage;
        }
    }
}