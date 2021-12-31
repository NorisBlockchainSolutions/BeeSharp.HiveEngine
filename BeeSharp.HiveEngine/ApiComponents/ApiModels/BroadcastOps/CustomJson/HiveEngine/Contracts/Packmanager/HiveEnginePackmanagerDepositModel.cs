using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Packmanager
{
    [HiveEngineContract("packmanager", "deposit")]
    public class HiveEnginePackmanagerDepositModel : HiveEngineOperation
    {
        [JsonPropertyName("nftSymbol")] public string NftSymbol { get; }
        [JsonPropertyName("amount")] public string Amount { get; }

        public HiveEnginePackmanagerDepositModel(string nftSymbol, string amount)
        {
            NftSymbol = nftSymbol;
            Amount = amount;
        }
    }
}