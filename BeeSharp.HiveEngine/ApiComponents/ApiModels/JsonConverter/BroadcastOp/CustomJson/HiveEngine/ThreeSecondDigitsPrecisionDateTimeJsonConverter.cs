using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BeeSharp.HiveEngine.ApiComponents.ApiModels.JsonConverter.BroadcastOp.CustomJson.HiveEngine
{
    public class ThreeSecondDigitsPrecisionDateTimeJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<DateTime>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var dateTimeValue = value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            JsonSerializer.Serialize(writer, dateTimeValue, options);
        }
    }
}