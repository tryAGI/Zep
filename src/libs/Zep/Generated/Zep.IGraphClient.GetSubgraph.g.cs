#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Get Subgraph<br/>
        /// Returns the bounded neighborhood of a set of seed nodes as a single {nodes, edges} payload: breadth-first expansion up to a caller-specified depth, subject to explicit budgets, with explicit truncation reporting.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphSubgraphResponse> GetSubgraphAsync(

            global::Zep.ApidataGraphSubgraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Subgraph<br/>
        /// Returns the bounded neighborhood of a set of seed nodes as a single {nodes, edges} payload: breadth-first expansion up to a caller-specified depth, subject to explicit budgets, with explicit truncation reporting.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphSubgraphResponse>> GetSubgraphAsResponseAsync(

            global::Zep.ApidataGraphSubgraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Subgraph<br/>
        /// Returns the bounded neighborhood of a set of seed nodes as a single {nodes, edges} payload: breadth-first expansion up to a caller-specified depth, subject to explicit budgets, with explicit truncation reporting.
        /// </summary>
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
        /// rejected: it cannot be enforced during graph traversal (spec-2 §9.4).
        /// </param>
        /// <param name="seedNodeUuids">
        /// Seed node UUIDs to expand from, in traversal-priority order: seeds are<br/>
        /// admitted before any expansion, in this order, and count toward<br/>
        /// max_nodes first. 1-20 entries, required. Seeds that do not exist in<br/>
        /// the target graph are ignored, not an error.
        /// </param>
        /// <param name="userId">
        /// user_id identifies the target user graph. Exactly one of user_id or<br/>
        /// graph_id is required.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphSubgraphResponse> GetSubgraphAsync(
            global::System.Collections.Generic.IList<string> seedNodeUuids,
            int? depth = default,
            string? direction = default,
            string? graphId = default,
            int? maxEdges = default,
            int? maxNodes = default,
            global::Zep.GraphitiSearchFilters? searchFilters = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}