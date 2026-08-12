#nullable enable

namespace Zep
{
    public partial interface IGraphNodeClient
    {
        /// <summary>
        /// Get Node Neighbors<br/>
        /// Enumerates the distinct entity nodes directly connected to a node, together with the edges connecting each to it.
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphNodeNeighbor>> GetNeighborsAsync(
            string nodeUuid,

            global::Zep.ApidataGraphNodeNeighborsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Node Neighbors<br/>
        /// Enumerates the distinct entity nodes directly connected to a node, together with the edges connecting each to it.
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.ApidataGraphNodeNeighbor>>> GetNeighborsAsResponseAsync(
            string nodeUuid,

            global::Zep.ApidataGraphNodeNeighborsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Node Neighbors<br/>
        /// Enumerates the distinct entity nodes directly connected to a node, together with the edges connecting each to it.
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </param>
        /// <param name="direction">
        /// Orientation of the connecting edge relative to the anchor node: "out"<br/>
        /// (anchor is the edge's source), "in" (anchor is the edge's target), or<br/>
        /// "both" (either). Defaults to "both".
        /// </param>
        /// <param name="directionSort">
        /// Sort direction for order_by. One of "asc" or "desc". Defaults to<br/>
        /// "desc". Named direction_sort to avoid clashing with the traversal<br/>
        /// Direction field above.
        /// </param>
        /// <param name="filters">
        /// Filters constraining the connecting edges (edge types, dates, and the<br/>
        /// section-3 node-/episode-anchored fields) and the neighbor nodes<br/>
        /// (node_labels/exclude_node_labels). Reuses the graph.search filter<br/>
        /// type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of neighbor nodes to return. An explicit value is<br/>
        /// clamped to 50; when omitted, the default page size (100) applies.
        /// </param>
        /// <param name="orderBy">
        /// Field to sort neighbor nodes by. One of "uuid" or "created_at".<br/>
        /// Defaults to "uuid".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphNodeNeighbor>> GetNeighborsAsync(
            string nodeUuid,
            string? cursor = default,
            string? direction = default,
            string? directionSort = default,
            global::Zep.GraphitiSearchFilters? filters = default,
            int? limit = default,
            string? orderBy = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}