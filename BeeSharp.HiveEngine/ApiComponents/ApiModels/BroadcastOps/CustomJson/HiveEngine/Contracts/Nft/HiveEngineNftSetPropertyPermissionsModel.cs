using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Nft
{
    [HiveEngineContract("nft", "setPropertyPermissions")]
    public class HiveEngineNftSetPropertyPermissionsModel : HiveEngineOperation
    {
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("accounts")] public string[] Accounts { get; }
        [JsonPropertyName("contracts")] public object[] Contracts { get; }

        public HiveEngineNftSetPropertyPermissionsModel(string symbol, string name, string[] accounts,
            object[] contracts)
        {
            Symbol = symbol;
            Name = name;
            Accounts = accounts;
            Contracts = contracts;
        }
    }
}