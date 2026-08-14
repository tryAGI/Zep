#nullable enable

namespace Zep
{
    public partial interface IThreadClient
    {
        /// <summary>
        /// Get Episodes for a thread<br/>
        /// Returns graph episodes associated with a thread. Parallel to get_episodes_for_document for documents.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetEpisodesForAThreadAsync(
            string threadId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Episodes for a thread<br/>
        /// Returns graph episodes associated with a thread. Parallel to get_episodes_for_document for documents.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphEpisodeResponse>> GetEpisodesForAThreadAsResponseAsync(
            string threadId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}