using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "setTraitName")]
    public class HiveEnginePackmanagerSetTraitNameModel : HiveEngineOperation
    {
        [JsonPropertyName("nftSymbol")] public string NftSymbol { get; }
        [JsonPropertyName("edition")] public uint Edition { get; }
        [JsonPropertyName("trait")] public string Trait { get; }
        [JsonPropertyName("index")] public uint Index { get; }
        [JsonPropertyName("name")] public string Name { get; }

        public HiveEnginePackmanagerSetTraitNameModel(string nftSymbol, uint edition, string trait, uint index,
            string name)
        {
            NftSymbol = nftSymbol;
            Edition = edition;
            Trait = trait;
            Index = index;
            Name = name;
        }
    }
}