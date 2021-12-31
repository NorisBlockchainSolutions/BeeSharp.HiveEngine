using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "removeAuthorizedIssuingAccounts")]
    public class HiveEngineNftRemoveAuthorizedIssuingAccountsModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("accounts")] public string[] Accounts { get; }

        public HiveEngineNftRemoveAuthorizedIssuingAccountsModel(string symbol, string[] accounts)
        {
            Symbol = symbol;
            Accounts = accounts;
        }
    }
}