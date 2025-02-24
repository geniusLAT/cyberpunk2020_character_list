using Cyberpunk2020GameEntities.Cybernetics;
using Cyberpunk2020GameEntities.Cybernetics.CyberwearsPlacedInTheBody;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cyberpunk2020CharacterManagerWindowsApp;

internal class BodyPartConverter : JsonConverter<BodyPart>
{
    public override BodyPart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        //using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        //{
        //    var root = doc.RootElement;
        //    string type = root.GetProperty("Type").GetString();

        //    return type switch
        //    {
        //        "Leg" => JsonSerializer.Deserialize<Leg>(root.GetRawText(), options),
        //        "Arm" => JsonSerializer.Deserialize<Arm>(root.GetRawText(), options),
        //        _ => throw new NotSupportedException($"Type '{type}' is not supported")
        //    };
        //}
        return new Gills();
    }

    public override void Write(Utf8JsonWriter writer, BodyPart value, JsonSerializerOptions options)
    {
        //switch (value)
        //{
        //    case Leg leg:
        //        writer.WriteStartObject();
        //        writer.WriteString("Type", "Leg");
        //        writer.WriteString("Name", leg.Name);
        //        writer.WriteEndObject();
        //        break;
        //    case Arm arm:
        //        writer.WriteStartObject();
        //        writer.WriteString("Type", "Arm");
        //        writer.WriteString("Name", arm.Name);
        //        writer.WriteEndObject();
        //        break;
        //    default:
        //        throw new NotSupportedException($"Type '{value.GetType()}' is not supported");
        //}

    }
}
