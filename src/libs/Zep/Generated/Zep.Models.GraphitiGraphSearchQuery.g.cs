
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiGraphSearchQuery
    {
        /// <summary>
        /// Nodes that are the origins of the BFS searches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bfs_origin_node_uuids")]
        public global::System.Collections.Generic.IList<string>? BfsOriginNodeUuids { get; set; }

        /// <summary>
        /// Node to rerank around for node distance reranking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_node_uuid")]
        public string? CenterNodeUuid { get; set; }

        /// <summary>
        /// The graph_id to search in. When searching user graph, please use user_id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// The maximum number of facts to retrieve for non-auto scopes. Defaults to 10. Limited to 50. Ignored when scope=auto.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Maximum total characters across all selected results when scope=auto. Defaults to 2500. Limited to 50000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// weighting for maximal marginal relevance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmr_lambda")]
        public double? MmrLambda { get; set; }

        /// <summary>
        /// The string to search for (required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Defaults to RRF. Ignored when scope=auto except node_distance and episode_mentions are rejected;<br/>
        /// auto search always uses RRF retrieval and applies its own internal rerank after retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiRerankerJsonConverter))]
        public global::Zep.GraphitiReranker? Reranker { get; set; }

        /// <summary>
        /// When scope=auto, include the selected raw graph results alongside the materialized context block.<br/>
        /// For graph-service-backed auto mode, selected raw results may include episodes,<br/>
        /// edges, nodes, observations, and thread_summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_raw_results")]
        public bool? ReturnRawResults { get; set; }

        /// <summary>
        /// Defaults to Edges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiGraphSearchScopeJsonConverter))]
        public global::Zep.GraphitiGraphSearchScope? Scope { get; set; }

        /// <summary>
        /// Search filters to apply to the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_filters")]
        public global::Zep.GraphitiSearchFilters? SearchFilters { get; set; }

        /// <summary>
        /// The user_id when searching user graph. If not searching user graph, please use graph_id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiGraphSearchQuery" /> class.
        /// </summary>
        /// <param name="query">
        /// The string to search for (required)
        /// </param>
        /// <param name="bfsOriginNodeUuids">
        /// Nodes that are the origins of the BFS searches
        /// </param>
        /// <param name="centerNodeUuid">
        /// Node to rerank around for node distance reranking
        /// </param>
        /// <param name="graphId">
        /// The graph_id to search in. When searching user graph, please use user_id instead.
        /// </param>
        /// <param name="limit">
        /// The maximum number of facts to retrieve for non-auto scopes. Defaults to 10. Limited to 50. Ignored when scope=auto.
        /// </param>
        /// <param name="maxCharacters">
        /// Maximum total characters across all selected results when scope=auto. Defaults to 2500. Limited to 50000.
        /// </param>
        /// <param name="mmrLambda">
        /// weighting for maximal marginal relevance
        /// </param>
        /// <param name="reranker">
        /// Defaults to RRF. Ignored when scope=auto except node_distance and episode_mentions are rejected;<br/>
        /// auto search always uses RRF retrieval and applies its own internal rerank after retrieval.
        /// </param>
        /// <param name="returnRawResults">
        /// When scope=auto, include the selected raw graph results alongside the materialized context block.<br/>
        /// For graph-service-backed auto mode, selected raw results may include episodes,<br/>
        /// edges, nodes, observations, and thread_summaries.
        /// </param>
        /// <param name="scope">
        /// Defaults to Edges.
        /// </param>
        /// <param name="searchFilters">
        /// Search filters to apply to the search
        /// </param>
        /// <param name="userId">
        /// The user_id when searching user graph. If not searching user graph, please use graph_id instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiGraphSearchQuery(
            string query,
            global::System.Collections.Generic.IList<string>? bfsOriginNodeUuids,
            string? centerNodeUuid,
            string? graphId,
            int? limit,
            int? maxCharacters,
            double? mmrLambda,
            global::Zep.GraphitiReranker? reranker,
            bool? returnRawResults,
            global::Zep.GraphitiGraphSearchScope? scope,
            global::Zep.GraphitiSearchFilters? searchFilters,
            string? userId)
        {
            this.BfsOriginNodeUuids = bfsOriginNodeUuids;
            this.CenterNodeUuid = centerNodeUuid;
            this.GraphId = graphId;
            this.Limit = limit;
            this.MaxCharacters = maxCharacters;
            this.MmrLambda = mmrLambda;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Reranker = reranker;
            this.ReturnRawResults = returnRawResults;
            this.Scope = scope;
            this.SearchFilters = searchFilters;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiGraphSearchQuery" /> class.
        /// </summary>
        public GraphitiGraphSearchQuery()
        {
        }

    }
}