
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GraphitiPropertyFilter
    {
        /// <summary>
        /// Comparison operator for property filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiComparisonOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.GraphitiComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Property name to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// Property value to match on. Accepted types: string, int, float64, bool, or nil.<br/>
        /// Invalid types (e.g., arrays, objects) will be rejected by validation.<br/>
        /// Must be non-nil for non-null operators (`=`, `&lt;&gt;`, `&gt;`, `&lt;`, `&gt;=`, `&lt;=`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_value")]
        public object? PropertyValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiPropertyFilter" /> class.
        /// </summary>
        /// <param name="comparisonOperator">
        /// Comparison operator for property filter
        /// </param>
        /// <param name="propertyName">
        /// Property name to filter on
        /// </param>
        /// <param name="propertyValue">
        /// Property value to match on. Accepted types: string, int, float64, bool, or nil.<br/>
        /// Invalid types (e.g., arrays, objects) will be rejected by validation.<br/>
        /// Must be non-nil for non-null operators (`=`, `&lt;&gt;`, `&gt;`, `&lt;`, `&gt;=`, `&lt;=`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiPropertyFilter(
            global::Zep.GraphitiComparisonOperator comparisonOperator,
            string propertyName,
            object? propertyValue)
        {
            this.ComparisonOperator = comparisonOperator;
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.PropertyValue = propertyValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiPropertyFilter" /> class.
        /// </summary>
        public GraphitiPropertyFilter()
        {
        }

    }
}