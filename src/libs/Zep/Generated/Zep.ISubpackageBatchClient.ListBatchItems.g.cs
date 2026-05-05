#nullable enable

namespace Zep
{
    public partial interface ISubpackageBatchClient
    {
        /// <summary>
        /// List Batch Items<br/>
        /// List items in a batch, including derived runtime status when the batch has been processed.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataBatchItemListResponse> ListBatchItemsAsync(
            string batchId,
            int? limit = default,
            int? cursor = default,
            string? status = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Batch Items<br/>
        /// List items in a batch, including derived runtime status when the batch has been processed.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataBatchItemListResponse>> ListBatchItemsAsResponseAsync(
            string batchId,
            int? limit = default,
            int? cursor = default,
            string? status = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}