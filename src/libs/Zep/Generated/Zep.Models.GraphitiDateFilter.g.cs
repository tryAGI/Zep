
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiDateFilter
    {
        /// <summary>
        /// Comparison operator for date filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiComparisonOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.GraphitiComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Date to filter on. Required for non-null operators (=, \&lt;\&gt;, \&gt;, \&lt;, \&gt;=, \&lt;=).<br/>
        /// Should be omitted for IS NULL (or is_null) and IS NOT NULL operators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiDateFilter" /> class.
        /// </summary>
        /// <param name="comparisonOperator">
        /// Comparison operator for date filter
        /// </param>
        /// <param name="date">
        /// Date to filter on. Required for non-null operators (=, \&lt;\&gt;, \&gt;, \&lt;, \&gt;=, \&lt;=).<br/>
        /// Should be omitted for IS NULL (or is_null) and IS NOT NULL operators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiDateFilter(
            global::Zep.GraphitiComparisonOperator comparisonOperator,
            string? date)
        {
            this.ComparisonOperator = comparisonOperator;
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiDateFilter" /> class.
        /// </summary>
        public GraphitiDateFilter()
        {
        }

    }
}