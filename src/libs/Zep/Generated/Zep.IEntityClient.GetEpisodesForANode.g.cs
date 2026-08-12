#nullable enable

namespace Zep
{
    public partial interface IEntityClient
    {
        /// <summary>
        /// Get Episodes for a node<br/>
        /// Deprecated. Use episode listing with `mentioned_node_uuids` (`POST /graph/episodes/graph/{graph_id}` or `POST /graph/episodes/user/{user_id}`) instead. Returns episodes that mentioned a given node, subject to an internal cap; responses reduced by that cap set the Zep-Truncated header.
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetEpisodesForANodeAsync(
            string nodeUuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Episodes for a node<br/>
        /// Deprecated. Use episode listing with `mentioned_node_uuids` (`POST /graph/episodes/graph/{graph_id}` or `POST /graph/episodes/user/{user_id}`) instead. Returns episodes that mentioned a given node, subject to an internal cap; responses reduced by that cap set the Zep-Truncated header.
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphEpisodeResponse>> GetEpisodesForANodeAsResponseAsync(
            string nodeUuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}