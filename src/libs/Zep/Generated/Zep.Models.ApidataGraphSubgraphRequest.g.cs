
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataGraphSubgraphRequest
    {
        /// <summary>
        /// Maximum traversal depth from the seeds. 1-3. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Edge orientation followed during expansion, relative to each frontier<br/>
        /// node: "in" | "out" | "both". Defaults to "both".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }

        /// <summary>
        /// graph_id identifies the target named graph. Exactly one of user_id or<br/>
        /// graph_id is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// Maximum number of edges in the response. 1-1000. Defaults to 200.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_edges")]
        public int? MaxEdges { get; set; }

        /// <summary>
        /// Maximum number of nodes in the response, including admitted seeds.<br/>
        /// 1-500. Defaults to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_nodes")]
        public int? MaxNodes { get; set; }

        /// <summary>
        /// Filters constraining traversed edges and included nodes. Reuses the<br/>
        /// graph.search filter type. search_filters.episode_metadata_filters is<br/>
        /// rejected: it cannot be enforced during graph traversal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_filters")]
        public global::Zep.GraphitiSearchFilters? SearchFilters { get; set; }

        /// <summary>
        /// Seed node UUIDs to expand from, in traversal-priority order: seeds are<br/>
        /// admitted before any expansion, in this order, and count toward<br/>
        /// max_nodes first. 1-20 entries, required. Seeds that do not exist in<br/>
        /// the target graph are ignored, not an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed_node_uuids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SeedNodeUuids { get; set; }

        /// <summary>
        /// user_id identifies the target user graph. Exactly one of user_id or<br/>
        /// graph_id is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSubgraphRequest" /> class.
        /// </summary>
        /// <param name="seedNodeUuids">
        /// Seed node UUIDs to expand from, in traversal-priority order: seeds are<br/>
        /// admitted before any expansion, in this order, and count toward<br/>
        /// max_nodes first. 1-20 entries, required. Seeds that do not exist in<br/>
        /// the target graph are ignored, not an error.
        /// </param>
        /// <param name="depth">
        /// Maximum traversal depth from the seeds. 1-3. Defaults to 1.
        /// </param>
        /// <param name="direction">
        /// Edge orientation followed during expansion, relative to each frontier<br/>
        /// node: "in" | "out" | "both". Defaults to "both".
        /// </param>
        /// <param name="graphId">
        /// graph_id identifies the target named graph. Exactly one of user_id or<br/>
        /// graph_id is required.
        /// </param>
        /// <param name="maxEdges">
        /// Maximum number of edges in the response. 1-1000. Defaults to 200.
        /// </param>
        /// <param name="maxNodes">
        /// Maximum number of nodes in the response, including admitted seeds.<br/>
        /// 1-500. Defaults to 100.
        /// </param>
        /// <param name="searchFilters">
        /// Filters constraining traversed edges and included nodes. Reuses the<br/>
        /// graph.search filter type. search_filters.episode_metadata_filters is<br/>
        /// rejected: it cannot be enforced during graph traversal.
        /// </param>
        /// <param name="userId">
        /// user_id identifies the target user graph. Exactly one of user_id or<br/>
        /// graph_id is required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphSubgraphRequest(
            global::System.Collections.Generic.IList<string> seedNodeUuids,
            int? depth,
            string? direction,
            string? graphId,
            int? maxEdges,
            int? maxNodes,
            global::Zep.GraphitiSearchFilters? searchFilters,
            string? userId)
        {
            this.Depth = depth;
            this.Direction = direction;
            this.GraphId = graphId;
            this.MaxEdges = maxEdges;
            this.MaxNodes = maxNodes;
            this.SearchFilters = searchFilters;
            this.SeedNodeUuids = seedNodeUuids ?? throw new global::System.ArgumentNullException(nameof(seedNodeUuids));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSubgraphRequest" /> class.
        /// </summary>
        public ApidataGraphSubgraphRequest()
        {
        }

    }
}