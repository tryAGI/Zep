#nullable enable

namespace Zep.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApidataRecencyWeightNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zep.ApidataRecencyWeight?>
    {
        /// <inheritdoc />
        public override global::Zep.ApidataRecencyWeight? Read(
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
                        return global::Zep.ApidataRecencyWeightExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zep.ApidataRecencyWeight)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zep.ApidataRecencyWeight?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zep.ApidataRecencyWeight? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Zep.ApidataRecencyWeightExtensions.ToValueString(value.Value));
            }
        }
    }
}
