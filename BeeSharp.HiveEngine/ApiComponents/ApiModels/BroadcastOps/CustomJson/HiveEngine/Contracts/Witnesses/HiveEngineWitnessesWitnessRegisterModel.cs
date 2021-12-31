using System.Text.Json.Serialization;
using BeeSharp.ApiComponents.ApiModels;
using BeeSharp.ApiComponents.ApiModels.JsonConverter.Annotations;
using BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.Annotations;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.BroadcastOps.CustomJson.HiveEngine.Contracts.Witnesses
{
    [HiveEngineContract("witnesses", "register")]
    public class HiveEngineWitnessesWitnessRegisterModel : HiveEngineOperation
    {
        [JsonPropertyName("IP")] public string Ip { get; }
        [JsonPropertyName("RFCPort")] public NumberOrStringModel RfcPort { get; }
        [JsonPropertyName("P2PPort")] public NumberOrStringModel P2PPort { get; }
        [JsonPropertyName("signingKey")] public string SigningKey { get; }
        [JsonPropertyName("enabled")] public bool Enabled { get; }

        public HiveEngineWitnessesWitnessRegisterModel(string ip, NumberOrStringModel rfcPort,
            NumberOrStringModel p2PPort, string signingKey, bool enabled)
        {
            Ip = ip;
            RfcPort = rfcPort;
            P2PPort = p2PPort;
            SigningKey = signingKey;
            Enabled = enabled;
        }
    }
}