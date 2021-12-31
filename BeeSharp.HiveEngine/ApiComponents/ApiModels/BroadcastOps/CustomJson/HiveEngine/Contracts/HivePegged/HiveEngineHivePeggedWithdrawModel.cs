using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.HivePegged
{
    [HiveEngineContract("hivepegged", "withdraw")]
    public class HiveEngineHivePeggedWithdrawModel : HiveEngineOperation
    {
        [JsonPropertyName("quantity")] public string Quantity { get; }

        public HiveEngineHivePeggedWithdrawModel(string quantity)
        {
            Quantity = quantity;
        }
    }
}