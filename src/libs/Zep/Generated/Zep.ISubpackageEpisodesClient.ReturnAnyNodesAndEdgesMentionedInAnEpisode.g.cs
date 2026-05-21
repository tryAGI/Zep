#nullable enable

namespace Zep
{
    public partial interface ISubpackageEpisodesClient
    {
        /// <summary>
        /// Return any nodes and edges mentioned in an episode<br/>
        /// Returns nodes and edges mentioned in an episode
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataEpisodeMentions> ReturnAnyNodesAndEdgesMentionedInAnEpisodeAsync(
            string uuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return any nodes and edges mentioned in an episode<br/>
        /// Returns nodes and edges mentioned in an episode
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataEpisodeMentions>> ReturnAnyNodesAndEdgesMentionedInAnEpisodeAsResponseAsync(
            string uuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}