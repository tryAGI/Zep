#nullable enable

namespace Zep
{
    public partial interface ISubpackageDataClient
    {
        /// <summary>
        /// Add Data<br/>
        /// Add data to the graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisode> AddDataAsync(

            global::Zep.ApidataAddDataRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data<br/>
        /// Add data to the graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphEpisode>> AddDataAsResponseAsync(

            global::Zep.ApidataAddDataRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data<br/>
        /// Add data to the graph.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="data"></param>
        /// <param name="graphId">
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs. Max 10 keys. Values must be strings, numbers, booleans, or arrays of scalars.
        /// </param>
        /// <param name="sourceDescription"></param>
        /// <param name="type"></param>
        /// <param name="userId">
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisode> AddDataAsync(
            string data,
            global::Zep.ModelsGraphDataType type,
            string? createdAt = default,
            string? graphId = default,
            object? metadata = default,
            string? sourceDescription = default,
            string? userId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}