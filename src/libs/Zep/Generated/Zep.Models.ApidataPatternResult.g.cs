
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataPatternResult
    {
        /// <summary>
        /// Human-readable description of the pattern
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
        /// Raw occurrence count (always unweighted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurrences")]
        public int? Occurrences { get; set; }

        /// <summary>
        /// Pattern type: relationship, path, co_occurrence, hub, cluster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Weighted sum — equals occurrences when recency_weight is "none"
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
        /// Human-readable description of the pattern
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
        /// Raw occurrence count (always unweighted)
        /// </param>
        /// <param name="type">
        /// Pattern type: relationship, path, co_occurrence, hub, cluster
        /// </param>
        /// <param name="weightedScore">
        /// Weighted sum — equals occurrences when recency_weight is "none"
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
            string? type,
            double? weightedScore)
        {
            this.Description = description;
            this.EdgeTypes = edgeTypes;
            this.Edges = edges;
            this.NodeLabels = nodeLabels;
            this.Occurrences = occurrences;
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