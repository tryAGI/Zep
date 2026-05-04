#nullable enable

namespace Zep
{
    public partial interface ISubpackageSearchClient
    {
        /// <summary>
        /// Search Graph<br/>
        /// Perform a graph search query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphSearchResults> GraphAsync(

            global::Zep.GraphitiGraphSearchQuery request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Graph<br/>
        /// Perform a graph search query.
        /// </summary>
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
        /// The maximum number of facts to retrieve. Defaults to 10. Limited to 50.
        /// </param>
        /// <param name="maxCharacters">
        /// Maximum total characters across all selected results when scope=auto. Defaults to 2500. Limited to 50000.
        /// </param>
        /// <param name="mmrLambda">
        /// weighting for maximal marginal relevance
        /// </param>
        /// <param name="query">
        /// The string to search for (required)
        /// </param>
        /// <param name="reranker">
        /// Defaults to RRF. When scope=auto, this only affects graph-service retrieval<br/>
        /// shape for graph facts, observations, and thread summaries; source-episode<br/>
        /// retrieval uses RRF, and auto search applies its own internal rerank after retrieval.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphSearchResults> GraphAsync(
            string query,
            global::System.Collections.Generic.IList<string>? bfsOriginNodeUuids = default,
            string? centerNodeUuid = default,
            string? graphId = default,
            int? limit = default,
            int? maxCharacters = default,
            double? mmrLambda = default,
            global::Zep.GraphitiReranker? reranker = default,
            bool? returnRawResults = default,
            global::Zep.GraphitiGraphSearchScope? scope = default,
            global::Zep.GraphitiSearchFilters? searchFilters = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}