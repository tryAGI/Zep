
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataGraphSubgraphResponse
    {
        /// <summary>
        /// Every traversed edge that passed the request filters. Both endpoints<br/>
        /// of every edge are present in Nodes (edge-endpoint closure).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? Edges { get; set; }

        /// <summary>
        /// Every admitted seed and every node reached within budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? Nodes { get; set; }

        /// <summary>
        /// True whenever any budget or internal limit reduced the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        /// Names the binding limit (for example "max_nodes", "max_edges") when<br/>
        /// Truncated is true; nil otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_reason")]
        public string? TruncationReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSubgraphResponse" /> class.
        /// </summary>
        /// <param name="edges">
        /// Every traversed edge that passed the request filters. Both endpoints<br/>
        /// of every edge are present in Nodes (edge-endpoint closure).
        /// </param>
        /// <param name="nodes">
        /// Every admitted seed and every node reached within budget.
        /// </param>
        /// <param name="truncated">
        /// True whenever any budget or internal limit reduced the result.
        /// </param>
        /// <param name="truncationReason">
        /// Names the binding limit (for example "max_nodes", "max_edges") when<br/>
        /// Truncated is true; nil otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphSubgraphResponse(
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? nodes,
            bool? truncated,
            string? truncationReason)
        {
            this.Edges = edges;
            this.Nodes = nodes;
            this.Truncated = truncated;
            this.TruncationReason = truncationReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSubgraphResponse" /> class.
        /// </summary>
        public ApidataGraphSubgraphResponse()
        {
        }

    }
}