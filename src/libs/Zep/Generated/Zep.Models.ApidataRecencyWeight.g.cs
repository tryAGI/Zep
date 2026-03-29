
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApidataRecencyWeight
    {
        /// <summary>
        /// 
        /// </summary>
        x30Days,
        /// <summary>
        /// 
        /// </summary>
        x7Days,
        /// <summary>
        /// 
        /// </summary>
        x90Days,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApidataRecencyWeightExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApidataRecencyWeight value)
        {
            return value switch
            {
                ApidataRecencyWeight.x30Days => "30_days",
                ApidataRecencyWeight.x7Days => "7_days",
                ApidataRecencyWeight.x90Days => "90_days",
                ApidataRecencyWeight.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApidataRecencyWeight? ToEnum(string value)
        {
            return value switch
            {
                "30_days" => ApidataRecencyWeight.x30Days,
                "7_days" => ApidataRecencyWeight.x7Days,
                "90_days" => ApidataRecencyWeight.x90Days,
                "none" => ApidataRecencyWeight.None,
                _ => null,
            };
        }
    }
}