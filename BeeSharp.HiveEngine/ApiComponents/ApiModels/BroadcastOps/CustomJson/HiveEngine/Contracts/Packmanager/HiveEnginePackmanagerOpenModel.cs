using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "open")]
    public class HiveEnginePackmanagerOpenModel : HiveEngineOperation
    {
        [JsonPropertyName("nftSymbol")] public string NftSymbol { get; }
        [JsonPropertyName("packSymbol")] public string PackSymbol { get; }
        [JsonPropertyName("packs")] public uint Packs { get; }

        public HiveEnginePackmanagerOpenModel(string nftSymbol, string packSymbol, uint packs)
        {
            NftSymbol = nftSymbol;
            PackSymbol = packSymbol;
            Packs = packs;
        }
    }
}