#nullable enable

namespace Zep
{
    public partial interface IThreadClient
    {
        /// <summary>
        /// Add messages to a thread in batch<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*` with `type: "thread_message"`) instead.<br/>
        /// Adds messages to a thread in batch mode, processing messages concurrently.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataAddThreadMessagesResponse> AddMessagesToAThreadInBatchAsync(
            string threadId,

            global::Zep.ApidataAddThreadMessagesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add messages to a thread in batch<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*` with `type: "thread_message"`) instead.<br/>
        /// Adds messages to a thread in batch mode, processing messages concurrently.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataAddThreadMessagesResponse>> AddMessagesToAThreadInBatchAsResponseAsync(
            string threadId,

            global::Zep.ApidataAddThreadMessagesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add messages to a thread in batch<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*` with `type: "thread_message"`) instead.<br/>
        /// Adds messages to a thread in batch mode, processing messages concurrently.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="ignoreRoles">
        /// Optional list of role types to ignore when adding messages to graph memory.<br/>
        /// The message itself will still be added, retained and used as context for messages<br/>
        /// that are added to a user's graph.
        /// </param>
        /// <param name="messages">
        /// A list of message objects, where each message contains a role and content.
        /// </param>
        /// <param name="returnContext">
        /// Optionally return context block relevant to the most recent messages.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataAddThreadMessagesResponse> AddMessagesToAThreadInBatchAsync(
            string threadId,
            global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage> messages,
            global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? ignoreRoles = default,
            bool? returnContext = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}