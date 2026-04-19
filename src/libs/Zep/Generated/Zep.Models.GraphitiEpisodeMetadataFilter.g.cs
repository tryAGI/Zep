
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiEpisodeMetadataFilter
    {
        /// <summary>
        /// Comparison operator: =, &lt;&gt;, &gt;, &lt;, &gt;=, &lt;=, IS NULL, IS NOT NULL, IN, CONTAINS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiComparisonOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.GraphitiComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Metadata key to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// Value to compare against. Not required for IS NULL / IS NOT NULL operators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_value")]
        public object? PropertyValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEpisodeMetadataFilter" /> class.
        /// </summary>
        /// <param name="comparisonOperator">
        /// Comparison operator: =, &lt;&gt;, &gt;, &lt;, &gt;=, &lt;=, IS NULL, IS NOT NULL, IN, CONTAINS
        /// </param>
        /// <param name="propertyName">
        /// Metadata key to filter on
        /// </param>
        /// <param name="propertyValue">
        /// Value to compare against. Not required for IS NULL / IS NOT NULL operators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiEpisodeMetadataFilter(
            global::Zep.GraphitiComparisonOperator comparisonOperator,
            string propertyName,
            object? propertyValue)
        {
            this.ComparisonOperator = comparisonOperator;
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.PropertyValue = propertyValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEpisodeMetadataFilter" /> class.
        /// </summary>
        public GraphitiEpisodeMetadataFilter()
        {
        }
    }
}