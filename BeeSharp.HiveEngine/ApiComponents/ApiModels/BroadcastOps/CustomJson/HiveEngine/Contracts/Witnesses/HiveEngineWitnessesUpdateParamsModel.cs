using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Witnesses
{
    [HiveEngineContract("witnesses", "updateParams")]
    public class HiveEngineWitnessesUpdateParamsModel : HiveEngineOperation
    {
        [JsonPropertyName("witnessSignaturesRequired")]
        public uint WitnessSignaturesRequired { get; }

        [JsonPropertyName("numberOfTopWitnesses")]
        public uint NumberOfTopWitnesses { get; }

        [JsonPropertyName("numberOfWitnessSlots")]
        public uint NumberOfWitnessSlots { get; }

        public HiveEngineWitnessesUpdateParamsModel(uint witnessSignaturesRequired, uint numberOfTopWitnesses,
            uint numberOfWitnessSlots)
        {
            WitnessSignaturesRequired = witnessSignaturesRequired;
            NumberOfTopWitnesses = numberOfTopWitnesses;
            NumberOfWitnessSlots = numberOfWitnessSlots;
        }
    }
}