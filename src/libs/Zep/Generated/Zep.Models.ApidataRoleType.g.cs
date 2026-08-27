
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public enum ApidataRoleType
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Norole,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApidataRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApidataRoleType value)
        {
            return value switch
            {
                ApidataRoleType.Assistant => "assistant",
                ApidataRoleType.Function => "function",
                ApidataRoleType.Norole => "norole",
                ApidataRoleType.System => "system",
                ApidataRoleType.Tool => "tool",
                ApidataRoleType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApidataRoleType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ApidataRoleType.Assistant,
                "function" => ApidataRoleType.Function,
                "norole" => ApidataRoleType.Norole,
                "system" => ApidataRoleType.System,
                "tool" => ApidataRoleType.Tool,
                "user" => ApidataRoleType.User,
                _ => null,
            };
        }
    }
}