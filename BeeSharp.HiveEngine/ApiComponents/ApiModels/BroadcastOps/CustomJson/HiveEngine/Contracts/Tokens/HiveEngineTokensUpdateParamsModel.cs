using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Tokens
{
    [HiveEngineContract("tokens", "updateParams")]
    public class HiveEngineTokensUpdateParamsModel : HiveEngineOperation
    {
        [JsonPropertyName("blacklist")] public object Blacklist { get; }

        public HiveEngineTokensUpdateParamsModel(object blacklist)
        {
            Blacklist = blacklist;
        }
    }
}