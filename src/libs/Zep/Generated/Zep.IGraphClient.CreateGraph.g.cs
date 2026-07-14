#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Create Graph<br/>
        /// Creates a new graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> CreateGraphAsync(

            global::Zep.ApidataCreateGraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Graph<br/>
        /// Creates a new graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraph>> CreateGraphAsResponseAsync(

            global::Zep.ApidataCreateGraphRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Graph<br/>
        /// Creates a new graph.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="graphId"></param>
        /// <param name="name"></param>
        /// <param name="timeZone">
        /// The graph's IANA time zone. Stored on its group-backed subject.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> CreateGraphAsync(
            string graphId,
            string? description = default,
            string? name = default,
            string? timeZone = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}