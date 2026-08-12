#nullable enable

namespace Zep
{
    public partial interface IEntityClient
    {
        /// <summary>
        /// Get Entity Edges for a node<br/>
        /// Deprecated. Use edge listing with `filters.connected_node_uuids`, or the neighbors endpoint (`POST /graph/node/{node_uuid}/neighbors`), instead. Returns all edges for a node, subject to an internal cap; responses reduced by that cap set the Zep-Truncated header.
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
        /// Deprecated. Use edge listing with `filters.connected_node_uuids`, or the neighbors endpoint (`POST /graph/node/{node_uuid}/neighbors`), instead. Returns all edges for a node, subject to an internal cap; responses reduced by that cap set the Zep-Truncated header.
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