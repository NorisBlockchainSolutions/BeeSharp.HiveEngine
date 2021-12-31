using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "create")]
    public class HiveEngineTokensCreateModel : HiveEngineOperation
    {
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("symbol")] public string Symbol { get; }
        [JsonPropertyName("precision")] public int Precision { get; }
        [JsonPropertyName("maxSupply")] public string MaxSupply { get; }

        public HiveEngineTokensCreateModel(string name, string symbol, int precision, string maxSupply)
        {
            Name = name;
            Symbol = symbol;
            Precision = precision;
            MaxSupply = maxSupply;
        }
    }
}