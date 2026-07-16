#nullable enable

namespace Zep
{
    public partial interface IEntityClient
    {
        /// <summary>
        /// Add Nodes<br/>
        /// Add entity nodes to a user or graph directly, without episode ingestion. Up to 100 nodes per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiAddNodesResponse> AddNodesAsync(

            global::Zep.GraphitiAddNodesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Nodes<br/>
        /// Add entity nodes to a user or graph directly, without episode ingestion. Up to 100 nodes per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.GraphitiAddNodesResponse>> AddNodesAsResponseAsync(

            global::Zep.GraphitiAddNodesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Nodes<br/>
        /// Add entity nodes to a user or graph directly, without episode ingestion. Up to 100 nodes per request.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="nodes">
        /// The nodes to add. 1 to 100 items.
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiAddNodesResponse> AddNodesAsync(
            global::System.Collections.Generic.IList<global::Zep.GraphitiAddNodeItem> nodes,
            string? graphId = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}