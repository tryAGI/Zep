#nullable enable

namespace Zep.JsonConverters
{
    /// <inheritdoc />
    public sealed class GraphitiRerankerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zep.GraphitiReranker?>
    {
        /// <inheritdoc />
        public override global::Zep.GraphitiReranker? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Zep.GraphitiRerankerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zep.GraphitiReranker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zep.GraphitiReranker?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zep.GraphitiReranker? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Zep.GraphitiRerankerExtensions.ToValueString(value.Value));
            }
        }
    }
}
