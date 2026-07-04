#nullable enable

namespace Zep
{
    public partial interface IEntityClient
    {
        /// <summary>
        /// Get Edge<br/>
        /// Returns a specific edge by its UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityEdge> GetEdgeAsync(
            string uuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Edge<br/>
        /// Returns a specific edge by its UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.GraphitiEntityEdge>> GetEdgeAsResponseAsync(
            string uuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}