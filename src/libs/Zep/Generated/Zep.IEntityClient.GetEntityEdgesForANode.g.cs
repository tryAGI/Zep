#nullable enable

namespace Zep
{
    public partial interface IEntityClient
    {
        /// <summary>
        /// Get Entity Edges for a node<br/>
        /// Returns all edges for a node
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>> GetEntityEdgesForANodeAsync(
            string nodeUuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Entity Edges for a node<br/>
        /// Returns all edges for a node
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>>> GetEntityEdgesForANodeAsResponseAsync(
            string nodeUuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}