#nullable enable

namespace Zep
{
    public partial interface ISubpackageBatchClient
    {
        /// <summary>
        /// Add Batch Items<br/>
        /// Add graph episodes and thread messages to a draft batch. Items are appended in request order.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataBatchItemDetail>> AddBatchItemsAsync(
            string batchId,

            global::Zep.ApidataAddBatchItemsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Batch Items<br/>
        /// Add graph episodes and thread messages to a draft batch. Items are appended in request order.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.ApidataBatchItemDetail>>> AddBatchItemsAsResponseAsync(
            string batchId,

            global::Zep.ApidataAddBatchItemsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Batch Items<br/>
        /// Add graph episodes and thread messages to a draft batch. Items are appended in request order.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="items"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataBatchItemDetail>> AddBatchItemsAsync(
            string batchId,
            global::System.Collections.Generic.IList<global::Zep.ApidataBatchAddItem> items,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}