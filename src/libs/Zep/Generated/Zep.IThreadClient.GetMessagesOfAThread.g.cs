#nullable enable

namespace Zep
{
    public partial interface IThreadClient
    {
        /// <summary>
        /// Get messages of a thread<br/>
        /// Returns messages for a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="lastn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadMessageListResponse> GetMessagesOfAThreadAsync(
            string threadId,
            int? limit = default,
            long? cursor = default,
            int? lastn = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get messages of a thread<br/>
        /// Returns messages for a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="lastn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataThreadMessageListResponse>> GetMessagesOfAThreadAsResponseAsync(
            string threadId,
            int? limit = default,
            long? cursor = default,
            int? lastn = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}