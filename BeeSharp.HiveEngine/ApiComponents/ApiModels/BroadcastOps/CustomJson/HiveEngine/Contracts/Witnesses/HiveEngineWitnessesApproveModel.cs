using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Witnesses
{
    [HiveEngineContract("witnesses", "approve")]
    public class HiveEngineWitnessesApproveModel : HiveEngineOperation
    {
        [JsonPropertyName("witness")] public string Witness { get; }

        public HiveEngineWitnessesApproveModel(string witness)
        {
            Witness = witness;
        }
    }
}