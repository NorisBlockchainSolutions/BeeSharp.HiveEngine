using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Witnesses
{
    [HiveEngineContract("witnesses", "disapprove")]
    public class HiveEngineWitnessesDisapproveModel : HiveEngineOperation
    {
        [JsonPropertyName("witness")] public string Witness { get; }

        public HiveEngineWitnessesDisapproveModel(string witness)
        {
            Witness = witness;
        }
    }
}