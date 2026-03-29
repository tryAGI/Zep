
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataDetectPatternsRequest
    {
        /// <summary>
        /// Which pattern types to detect with type-specific configuration.<br/>
        /// Omit to detect all types with defaults. Ignored when query is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect")]
        public global::Zep.ApidataDetectConfig? Detect { get; set; }

        /// <summary>
        /// Max resolved edges per pattern. Default: 10, Max: 100. Only used with query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_limit")]
        public int? EdgeLimit { get; set; }

        /// <summary>
        /// Graph ID when detecting patterns on a named graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// Max patterns to return. Default: 50, Max: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Minimum occurrence count to report a pattern. Default: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_occurrences")]
        public int? MinOccurrences { get; set; }

        /// <summary>
        /// Search query for discovering seed nodes via hybrid search.<br/>
        /// When set, forces triple-frequency detection only and enables edge resolution<br/>
        /// with cross-encoder reranking. Mutually exclusive with seeds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Max seed nodes from search. Default: 10, Max: 50. Only used with query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_limit")]
        public int? QueryLimit { get; set; }

        /// <summary>
        /// Exponential half-life decay applied to edge created_at timestamps.<br/>
        /// Valid values: none, 7_days, 30_days, 90_days. Default: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recency_weight")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ApidataRecencyWeightJsonConverter))]
        public global::Zep.ApidataRecencyWeight? RecencyWeight { get; set; }

        /// <summary>
        /// Filters which edges/nodes participate in pattern detection.<br/>
        /// Reuses the same filter format as /graph/search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_filters")]
        public global::Zep.GraphitiSearchFilters? SearchFilters { get; set; }

        /// <summary>
        /// Seed selection. If omitted, analyzes the entire graph. Mutually exclusive with query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seeds")]
        public global::Zep.ApidataPatternSeeds? Seeds { get; set; }

        /// <summary>
        /// User ID when detecting patterns on a user graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectPatternsRequest" /> class.
        /// </summary>
        /// <param name="detect">
        /// Which pattern types to detect with type-specific configuration.<br/>
        /// Omit to detect all types with defaults. Ignored when query is set.
        /// </param>
        /// <param name="edgeLimit">
        /// Max resolved edges per pattern. Default: 10, Max: 100. Only used with query.
        /// </param>
        /// <param name="graphId">
        /// Graph ID when detecting patterns on a named graph
        /// </param>
        /// <param name="limit">
        /// Max patterns to return. Default: 50, Max: 200
        /// </param>
        /// <param name="minOccurrences">
        /// Minimum occurrence count to report a pattern. Default: 2
        /// </param>
        /// <param name="query">
        /// Search query for discovering seed nodes via hybrid search.<br/>
        /// When set, forces triple-frequency detection only and enables edge resolution<br/>
        /// with cross-encoder reranking. Mutually exclusive with seeds.
        /// </param>
        /// <param name="queryLimit">
        /// Max seed nodes from search. Default: 10, Max: 50. Only used with query.
        /// </param>
        /// <param name="recencyWeight">
        /// Exponential half-life decay applied to edge created_at timestamps.<br/>
        /// Valid values: none, 7_days, 30_days, 90_days. Default: none
        /// </param>
        /// <param name="searchFilters">
        /// Filters which edges/nodes participate in pattern detection.<br/>
        /// Reuses the same filter format as /graph/search.
        /// </param>
        /// <param name="seeds">
        /// Seed selection. If omitted, analyzes the entire graph. Mutually exclusive with query.
        /// </param>
        /// <param name="userId">
        /// User ID when detecting patterns on a user graph
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDetectPatternsRequest(
            global::Zep.ApidataDetectConfig? detect,
            int? edgeLimit,
            string? graphId,
            int? limit,
            int? minOccurrences,
            string? query,
            int? queryLimit,
            global::Zep.ApidataRecencyWeight? recencyWeight,
            global::Zep.GraphitiSearchFilters? searchFilters,
            global::Zep.ApidataPatternSeeds? seeds,
            string? userId)
        {
            this.Detect = detect;
            this.EdgeLimit = edgeLimit;
            this.GraphId = graphId;
            this.Limit = limit;
            this.MinOccurrences = minOccurrences;
            this.Query = query;
            this.QueryLimit = queryLimit;
            this.RecencyWeight = recencyWeight;
            this.SearchFilters = searchFilters;
            this.Seeds = seeds;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectPatternsRequest" /> class.
        /// </summary>
        public ApidataDetectPatternsRequest()
        {
        }
    }
}