using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "createNft")]
    public class HiveEnginePackmanagerCreateNftModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string symbol { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("orgName")] public string OrgName { get; }
        [JsonPropertyName("productName")] public string ProductName { get; }
        [JsonPropertyName("isFoilReadOnly")] public bool IsFoilReadOnly { get; }
        [JsonPropertyName("isTypeReadOnly")] public bool IsTypeReadOnly { get; }

        public HiveEnginePackmanagerCreateNftModel(string symbol, string name, string orgName, string productName,
            bool isFoilReadOnly, bool isTypeReadOnly)
        {
            this.symbol = symbol;
            Name = name;
            OrgName = orgName;
            ProductName = productName;
            IsFoilReadOnly = isFoilReadOnly;
            IsTypeReadOnly = isTypeReadOnly;
        }
    }
}