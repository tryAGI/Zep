#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Update Node<br/>
        /// Updates an entity node by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityNode> UpdateNodeAsync(
            string uuid,

            global::Zep.ApidataUpdateNodeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Node<br/>
        /// Updates an entity node by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.GraphitiEntityNode>> UpdateNodeAsResponseAsync(
            string uuid,

            global::Zep.ApidataUpdateNodeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Node<br/>
        /// Updates an entity node by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="attributes">
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </param>
        /// <param name="labels">
        /// Updated labels for the node
        /// </param>
        /// <param name="name">
        /// Updated name for the node
        /// </param>
        /// <param name="summary">
        /// Updated summary for the node
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityNode> UpdateNodeAsync(
            string uuid,
            object? attributes = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            string? name = default,
            string? summary = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}