using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "registerPack")]
    public class HiveEnginePackmanagerRegisterPackModel : HiveEngineOperation
    {
        [JsonPropertyName("packSymbol")] public string PackSymbol { get; }
        [JsonPropertyName("nftSymbol")] public string NftSymbol { get; }
        [JsonPropertyName("editionName")] public string EditionName { get; }
        [JsonPropertyName("edition")] public uint Edition { get; }
        [JsonPropertyName("cardsPerPack")] public uint CardsPerPack { get; }
        [JsonPropertyName("foilChance")] public uint[] FoilChance { get; }
        [JsonPropertyName("categoryChance")] public uint[] CategoryChance { get; }
        [JsonPropertyName("rarityChance")] public uint[] RarityChance { get; }
        [JsonPropertyName("teamChance")] public uint[] TeamChance { get; }
        [JsonPropertyName("numRolls")] public uint NumRolls { get; }

        public HiveEnginePackmanagerRegisterPackModel(string packSymbol, string nftSymbol, string editionName,
            uint edition, uint cardsPerPack, uint[] foilChance, uint[] categoryChance, uint[] rarityChance,
            uint[] teamChance, uint numRolls)
        {
            PackSymbol = packSymbol;
            NftSymbol = nftSymbol;
            EditionName = editionName;
            Edition = edition;
            CardsPerPack = cardsPerPack;
            FoilChance = foilChance;
            CategoryChance = categoryChance;
            RarityChance = rarityChance;
            TeamChance = teamChance;
            NumRolls = numRolls;
        }
    }
}