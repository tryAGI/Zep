#nullable enable

namespace Zep
{
    public partial interface IDataClient
    {
        /// <summary>
        /// Clone graph<br/>
        /// Clone a user or group graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataCloneGraphResponse> CloneGraphAsync(

            global::Zep.ApidataCloneGraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone graph<br/>
        /// Clone a user or group graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataCloneGraphResponse>> CloneGraphAsResponseAsync(

            global::Zep.ApidataCloneGraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone graph<br/>
        /// Clone a user or group graph.
        /// </summary>
        /// <param name="sourceGraphId">
        /// source_graph_id is the ID of the graph to be cloned. Required if source_user_id is not provided
        /// </param>
        /// <param name="sourceUserId">
        /// user_id of the user whose graph is being cloned. Required if source_graph_id is not provided
        /// </param>
        /// <param name="targetGraphId">
        /// target_graph_id is the ID to be set on the cloned graph. Must not point to an existing graph. Required if target_user_id is not provided.
        /// </param>
        /// <param name="targetUserId">
        /// user_id to be set on the cloned user. Must not point to an existing user. Required if target_graph_id is not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataCloneGraphResponse> CloneGraphAsync(
            string? sourceGraphId = default,
            string? sourceUserId = default,
            string? targetGraphId = default,
            string? targetUserId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}