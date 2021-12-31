using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "updateOrgName")]
    public class HiveEngineNftUpdateOrgNameModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("orgName")] public string OrgName { get; }

        public HiveEngineNftUpdateOrgNameModel(string symbol, string orgName)
        {
            Symbol = symbol;
            OrgName = orgName;
        }
    }
}