using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "addType")]
    public class HiveEnginePackmanagerAddTypeModel : HiveEngineOperation
    {
        [JsonPropertyName("nftSymbol")] public string NftSymbol { get; }
        [JsonPropertyName("edition")] public uint Edition { get; }
        [JsonPropertyName("name")] public string Name { get; }
        [JsonPropertyName("category")] public uint Category { get; }
        [JsonPropertyName("rarity")] public uint Rarity { get; }
        [JsonPropertyName("team")] public uint Team { get; }

        public HiveEnginePackmanagerAddTypeModel(string nftSymbol, uint edition, string name, uint category,
            uint rarity, uint team)
        {
            NftSymbol = nftSymbol;
            Edition = edition;
            Name = name;
            Category = category;
            Rarity = rarity;
            Team = team;
        }
    }
}