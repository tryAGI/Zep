#nullable enable

namespace Zep
{
    public partial interface ISubpackageThreadSummaryClient
    {
        /// <summary>
        /// Get User Thread Summaries<br/>
        /// Returns incremental thread summaries generated from messages in each thread associated with the user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataThreadSummary>> GetUserThreadSummariesAsync(
            string userId,

            global::Zep.ApidataGraphThreadSummariesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Thread Summaries<br/>
        /// Returns incremental thread summaries generated from messages in each thread associated with the user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.ApidataThreadSummary>>> GetUserThreadSummariesAsResponseAsync(
            string userId,

            global::Zep.ApidataGraphThreadSummariesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Thread Summaries<br/>
        /// Returns incremental thread summaries generated from messages in each thread associated with the user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataThreadSummary>> GetUserThreadSummariesAsync(
            string userId,
            int? limit = default,
            string? uuidCursor = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}