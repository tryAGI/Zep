#nullable enable

namespace Zep
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create Batch<br/>
        /// Create a draft batch that can be filled with graph episodes and thread messages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataBatchSummary> CreateBatchAsync(

            global::Zep.ApidataCreateBatchRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a draft batch that can be filled with graph episodes and thread messages.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataBatchSummary>> CreateBatchAsResponseAsync(

            global::Zep.ApidataCreateBatchRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a draft batch that can be filled with graph episodes and thread messages.
        /// </summary>
        /// <param name="ignoreRoles">
        /// Optional list of message role types to skip during graph ingestion for<br/>
        /// thread_message items in this batch. The messages are still stored and<br/>
        /// retained as context, but no graph extraction is performed for them.<br/>
        /// Has no effect on graph_episode items.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataBatchSummary> CreateBatchAsync(
            global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? ignoreRoles = default,
            object? metadata = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}