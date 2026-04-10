#nullable enable

namespace Zep
{
    public partial interface ISubpackageThreadClient
    {
        /// <summary>
        /// Get user context<br/>
        /// Returns most relevant context from the user graph (including memory from any/all past threads) based on the content of the past few messages of the given thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadContextResponse> GetUserContextAsync(
            string threadId,
            string? templateId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}