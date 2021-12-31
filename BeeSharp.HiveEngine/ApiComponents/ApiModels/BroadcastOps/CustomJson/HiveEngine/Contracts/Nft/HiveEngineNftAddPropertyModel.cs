using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "addProperty")]
    public class HiveEngineNftAddPropertyModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("authorizedEditingAccounts")]
        public string[] AuthorizedEditingAccounts { get; }

        public HiveEngineNftAddPropertyModel(string symbol, string name, string type,
            string[] authorizedEditingAccounts)
        {
            Symbol = symbol;
            Name = name;
            Type = type;
            AuthorizedEditingAccounts = authorizedEditingAccounts;
        }
    }
}