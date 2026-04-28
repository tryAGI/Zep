
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelsGraphDataType
    {
        /// <summary>
        /// 
        /// </summary>
        FactTriple,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGraphDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGraphDataType value)
        {
            return value switch
            {
                ModelsGraphDataType.FactTriple => "fact_triple",
                ModelsGraphDataType.Json => "json",
                ModelsGraphDataType.Message => "message",
                ModelsGraphDataType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGraphDataType? ToEnum(string value)
        {
            return value switch
            {
                "fact_triple" => ModelsGraphDataType.FactTriple,
                "json" => ModelsGraphDataType.Json,
                "message" => ModelsGraphDataType.Message,
                "text" => ModelsGraphDataType.Text,
                _ => null,
            };
        }
    }
}