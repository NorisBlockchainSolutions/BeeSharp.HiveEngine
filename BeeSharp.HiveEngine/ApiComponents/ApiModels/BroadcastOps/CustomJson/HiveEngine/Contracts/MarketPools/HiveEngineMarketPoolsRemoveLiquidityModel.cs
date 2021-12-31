using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.MarketPools
{
    [HiveEngineContract("marketpools", "removeLiquidity")]
    public class HiveEngineMarketPoolsRemoveLiquidityModel : HiveEngineOperation
    {
        [JsonPropertyName("tokenPair")] public string TokenPair { get; }
        [JsonPropertyName("sharesOut")] public DecimalOrStringModel SharesOut { get; }

        public HiveEngineMarketPoolsRemoveLiquidityModel(string tokenPair, DecimalOrStringModel sharesOut)
        {
            TokenPair = tokenPair;
            SharesOut = sharesOut;
        }
    }
}