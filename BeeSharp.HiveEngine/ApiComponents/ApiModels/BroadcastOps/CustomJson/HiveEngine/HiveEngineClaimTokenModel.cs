using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.BroadcastOps.CustomJson;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine
{
    [CustomJsonOpId("scot_claim_token", typeof(ObjectListOrObjectWrapperModel<HiveEngineClaimTokenModel>))]
    public class HiveEngineClaimTokenModel
    {
        public HiveEngineClaimTokenModel(string symbol)
        {
            Symbol = symbol;
        }

        [JsonPropertyName("symbol")] public string Symbol { get; }
    }
}