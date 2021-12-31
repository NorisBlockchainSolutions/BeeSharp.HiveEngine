using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "create")]
    public class HiveEngineNftCreateModel : HiveEngineOperation
    {
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("orgName")] public string OrgName { get; }
        [JsonPropertyName("authorizedIssuingAccounts")]
        public string[] AuthorizedIssuingAccounts { get; }

        public HiveEngineNftCreateModel(string name, string symbol, string orgName, string[] authorizedIssuingAccounts)
        {
            Name = name;
            Symbol = symbol;
            OrgName = orgName;
            AuthorizedIssuingAccounts = authorizedIssuingAccounts;
        }
    }
}