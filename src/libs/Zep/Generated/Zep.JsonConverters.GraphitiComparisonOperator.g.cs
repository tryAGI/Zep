#nullable enable

namespace Zep.JsonConverters
{
    /// <inheritdoc />
    public sealed class GraphitiComparisonOperatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Zep.GraphitiComparisonOperator>
    {
        /// <inheritdoc />
        public override global::Zep.GraphitiComparisonOperator Read(
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
                        return global::Zep.GraphitiComparisonOperatorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Zep.GraphitiComparisonOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Zep.GraphitiComparisonOperator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Zep.GraphitiComparisonOperator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Zep.GraphitiComparisonOperatorExtensions.ToValueString(value));
        }
    }
}
