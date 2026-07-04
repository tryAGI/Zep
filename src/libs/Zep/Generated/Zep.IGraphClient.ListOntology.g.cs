#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// List graph ontology<br/>
        /// Retrieves the current entity and edge types configured for your graph.<br/>
        /// See the [full documentation](/customizing-graph-structure) for details.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataEntityTypeResponse> ListOntologyAsync(
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List graph ontology<br/>
        /// Retrieves the current entity and edge types configured for your graph.<br/>
        /// See the [full documentation](/customizing-graph-structure) for details.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataEntityTypeResponse>> ListOntologyAsResponseAsync(
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}