#nullable enable

namespace Zep
{
    public partial interface ISubpackageBatchClient
    {
        /// <summary>
        /// Delete Batch<br/>
        /// Delete a draft or invalid unprocessed batch. Processed batches cannot be deleted.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteBatchAsync(
            string batchId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}