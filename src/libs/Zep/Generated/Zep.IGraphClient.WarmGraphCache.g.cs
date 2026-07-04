#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Warm Graph Cache<br/>
        /// Hints Zep to warm a graph for low-latency search
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> WarmGraphCacheAsync(
            string graphId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Warm Graph Cache<br/>
        /// Hints Zep to warm a graph for low-latency search
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataSuccessResponse>> WarmGraphCacheAsResponseAsync(
            string graphId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}