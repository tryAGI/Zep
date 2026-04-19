
#nullable enable

namespace Zep
{
    /// <summary>
    /// Logical operator: "and" or "or"
    /// </summary>
    public enum GraphitiMetadataFilterGroupType
    {
        /// <summary>
        /// "and" or "or"
        /// </summary>
        And,
        /// <summary>
        /// "and" or "or"
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphitiMetadataFilterGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphitiMetadataFilterGroupType value)
        {
            return value switch
            {
                GraphitiMetadataFilterGroupType.And => "and",
                GraphitiMetadataFilterGroupType.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphitiMetadataFilterGroupType? ToEnum(string value)
        {
            return value switch
            {
                "and" => GraphitiMetadataFilterGroupType.And,
                "or" => GraphitiMetadataFilterGroupType.Or,
                _ => null,
            };
        }
    }
}