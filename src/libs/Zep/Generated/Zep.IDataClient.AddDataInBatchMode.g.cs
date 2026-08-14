#nullable enable

namespace Zep
{
    public partial interface IDataClient
    {
        /// <summary>
        /// Add Data in batch mode<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*`) instead.<br/>
        /// Adds data to the graph in batch mode, processing episodes concurrently.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> AddDataInBatchModeAsync(

            global::Zep.ApidataAddDataBatchRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data in batch mode<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*`) instead.<br/>
        /// Adds data to the graph in batch mode, processing episodes concurrently.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>>> AddDataInBatchModeAsResponseAsync(

            global::Zep.ApidataAddDataBatchRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data in batch mode<br/>
        /// Deprecated. Use the [Batch API](/adding-batch-data) (`client.batch.*`) instead.<br/>
        /// Adds data to the graph in batch mode, processing episodes concurrently.
        /// </summary>
        /// <param name="documentId">
        /// Optional document ID applied to every episode in this batch request.
        /// </param>
        /// <param name="episodes"></param>
        /// <param name="graphId">
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </param>
        /// <param name="strictOntology">
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </param>
        /// <param name="userId">
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> AddDataInBatchModeAsync(
            global::System.Collections.Generic.IList<global::Zep.ApidataEpisodeData> episodes,
            string? documentId = default,
            string? graphId = default,
            bool? strictOntology = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}