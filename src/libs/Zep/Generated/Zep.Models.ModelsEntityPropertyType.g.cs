
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelsEntityPropertyType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsEntityPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsEntityPropertyType value)
        {
            return value switch
            {
                ModelsEntityPropertyType.Boolean => "Boolean",
                ModelsEntityPropertyType.Float => "Float",
                ModelsEntityPropertyType.Int => "Int",
                ModelsEntityPropertyType.Text => "Text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsEntityPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "Boolean" => ModelsEntityPropertyType.Boolean,
                "Float" => ModelsEntityPropertyType.Float,
                "Int" => ModelsEntityPropertyType.Int,
                "Text" => ModelsEntityPropertyType.Text,
                _ => null,
            };
        }
    }
}