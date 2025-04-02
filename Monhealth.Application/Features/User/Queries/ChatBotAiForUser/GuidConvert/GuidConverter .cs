using System.Text.Json;
namespace Monhealth.Application
{
    public class GuidConverter : System.Text.Json.Serialization.JsonConverter<Guid>
    {
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string stringValue = reader.GetString();
            return Guid.TryParse(stringValue, out Guid result) ? result : Guid.Empty;
        }

        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}