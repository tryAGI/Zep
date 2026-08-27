
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsUserGroupKind
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        Virtual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsUserGroupKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsUserGroupKind value)
        {
            return value switch
            {
                ModelsUserGroupKind.Managed => "managed",
                ModelsUserGroupKind.Virtual => "virtual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsUserGroupKind? ToEnum(string value)
        {
            return value switch
            {
                "managed" => ModelsUserGroupKind.Managed,
                "virtual" => ModelsUserGroupKind.Virtual,
                _ => null,
            };
        }
    }
}