
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataPatternResult
    {
        /// <summary>
        /// Human-readable structural description of the pattern (e.g. "Person -[KNOWS]-&gt; Person").<br/>
        /// Omitted in query mode in favor of Summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Edge types in the pattern structure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_types")]
        public global::System.Collections.Generic.IList<string>? EdgeTypes { get; set; }

        /// <summary>
        /// Resolved edges for this pattern, sorted by cross-encoder relevance.<br/>
        /// Only populated when query is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? Edges { get; set; }

        /// <summary>
        /// Node labels in the pattern structure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_labels")]
        public global::System.Collections.Generic.IList<string>? NodeLabels { get; set; }

        /// <summary>
        /// Raw structural occurrence count (always unweighted).<br/>
        /// Reflects pattern frequency in the graph, not the number of resolved edges after filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurrences")]
        public int? Occurrences { get; set; }

        /// <summary>
        /// Fact-derived summary from top reranked edges. Only populated when query is set.<br/>
        /// This is the primary display field for QA consumers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Pattern type: relationship, path, co_occurrence, hub, cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Weighted structural support — equals occurrences when recency_weight is "none".<br/>
        /// Reflects graph-level support, not post-enrichment edge count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weighted_score")]
        public double? WeightedScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternResult" /> class.
        /// </summary>
        /// <param name="description">
        /// Human-readable structural description of the pattern (e.g. "Person -[KNOWS]-&gt; Person").<br/>
        /// Omitted in query mode in favor of Summary.
        /// </param>
        /// <param name="edgeTypes">
        /// Edge types in the pattern structure
        /// </param>
        /// <param name="edges">
        /// Resolved edges for this pattern, sorted by cross-encoder relevance.<br/>
        /// Only populated when query is set.
        /// </param>
        /// <param name="nodeLabels">
        /// Node labels in the pattern structure
        /// </param>
        /// <param name="occurrences">
        /// Raw structural occurrence count (always unweighted).<br/>
        /// Reflects pattern frequency in the graph, not the number of resolved edges after filtering.
        /// </param>
        /// <param name="summary">
        /// Fact-derived summary from top reranked edges. Only populated when query is set.<br/>
        /// This is the primary display field for QA consumers.
        /// </param>
        /// <param name="type">
        /// Pattern type: relationship, path, co_occurrence, hub, cluster
        /// </param>
        /// <param name="weightedScore">
        /// Weighted structural support — equals occurrences when recency_weight is "none".<br/>
        /// Reflects graph-level support, not post-enrichment edge count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataPatternResult(
            string? description,
            global::System.Collections.Generic.IList<string>? edgeTypes,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::System.Collections.Generic.IList<string>? nodeLabels,
            int? occurrences,
            string? summary,
            string? type,
            double? weightedScore)
        {
            this.Description = description;
            this.EdgeTypes = edgeTypes;
            this.Edges = edges;
            this.NodeLabels = nodeLabels;
            this.Occurrences = occurrences;
            this.Summary = summary;
            this.Type = type;
            this.WeightedScore = weightedScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternResult" /> class.
        /// </summary>
        public ApidataPatternResult()
        {
        }
    }
}