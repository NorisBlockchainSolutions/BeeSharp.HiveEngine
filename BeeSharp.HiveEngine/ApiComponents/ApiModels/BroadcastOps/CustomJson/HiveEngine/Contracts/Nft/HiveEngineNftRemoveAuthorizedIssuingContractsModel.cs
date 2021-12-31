using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "removeAuthorizedIssuingContracts")]
    public class HiveEngineNftRemoveAuthorizedIssuingContractsModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("accounts")] public string[] Accounts { get; }

        public HiveEngineNftRemoveAuthorizedIssuingContractsModel(string symbol, string[] accounts)
        {
            Symbol = symbol;
            Accounts = accounts;
        }
    }
}