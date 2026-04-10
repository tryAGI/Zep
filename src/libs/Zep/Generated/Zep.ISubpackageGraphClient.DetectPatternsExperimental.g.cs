#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Detect Patterns (Experimental)<br/>
        /// Detects structural patterns in a knowledge graph including relationship frequencies,<br/>
        /// multi-hop paths, co-occurrences, hubs, and clusters.<br/>
        /// When a query is provided, uses hybrid search to discover seed nodes,<br/>
        /// detects triple-frequency patterns, and returns resolved edges ranked by relevance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataDetectPatternsResponse> DetectPatternsExperimentalAsync(

            global::Zep.ApidataDetectPatternsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect Patterns (Experimental)<br/>
        /// Detects structural patterns in a knowledge graph including relationship frequencies,<br/>
        /// multi-hop paths, co-occurrences, hubs, and clusters.<br/>
        /// When a query is provided, uses hybrid search to discover seed nodes,<br/>
        /// detects triple-frequency patterns, and returns resolved edges ranked by relevance.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataDetectPatternsResponse> DetectPatternsExperimentalAsync(
            global::Zep.ApidataDetectConfig? detect = default,
            int? edgeLimit = default,
            string? graphId = default,
            int? limit = default,
            int? minOccurrences = default,
            string? query = default,
            int? queryLimit = default,
            global::Zep.ApidataRecencyWeight? recencyWeight = default,
            global::Zep.GraphitiSearchFilters? searchFilters = default,
            global::Zep.ApidataPatternSeeds? seeds = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}