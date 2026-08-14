#nullable enable

namespace Zep
{
    public partial interface IDocumentClient
    {
        /// <summary>
        /// Get Episodes for a document<br/>
        /// Returns episodes associated with a document on a graph. Documents group episodes as chunks, parallel to how threads group messages.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetEpisodesForADocumentAsync(
            string documentId,
            string graphId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Episodes for a document<br/>
        /// Returns episodes associated with a document on a graph. Documents group episodes as chunks, parallel to how threads group messages.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphEpisodeResponse>> GetEpisodesForADocumentAsResponseAsync(
            string documentId,
            string graphId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}