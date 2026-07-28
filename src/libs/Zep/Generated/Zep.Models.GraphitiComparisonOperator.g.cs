
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum GraphitiComparisonOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        IsNotNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull,
        /// <summary>
        /// 
        /// </summary>
        IsNull2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphitiComparisonOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphitiComparisonOperator value)
        {
            return value switch
            {
                GraphitiComparisonOperator.Lt => "<",
                GraphitiComparisonOperator.Lte => "<=",
                GraphitiComparisonOperator.x__ => "<>",
                GraphitiComparisonOperator.Eq => "=",
                GraphitiComparisonOperator.Gt => ">",
                GraphitiComparisonOperator.Gte => ">=",
                GraphitiComparisonOperator.Contains => "CONTAINS",
                GraphitiComparisonOperator.IsNotNull => "IS NOT NULL",
                GraphitiComparisonOperator.IsNull => "IS NULL",
                GraphitiComparisonOperator.IsNull2 => "is_null",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphitiComparisonOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => GraphitiComparisonOperator.Lt,
                "<=" => GraphitiComparisonOperator.Lte,
                "<>" => GraphitiComparisonOperator.x__,
                "=" => GraphitiComparisonOperator.Eq,
                ">" => GraphitiComparisonOperator.Gt,
                ">=" => GraphitiComparisonOperator.Gte,
                "CONTAINS" => GraphitiComparisonOperator.Contains,
                "IS NOT NULL" => GraphitiComparisonOperator.IsNotNull,
                "IS NULL" => GraphitiComparisonOperator.IsNull,
                "is_null" => GraphitiComparisonOperator.IsNull2,
                _ => null,
            };
        }
    }
}