#nullable enable

namespace Zep
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Retrieves observation steering configuration (Experimental)<br/>
        /// Returns project steering or the effective user/graph steering with project fallback. This API is experimental and may change in future releases.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataObservationSteeringConfig> RetrievesObservationSteeringConfigurationExperimentalAsync(
            string? userId = default,
            string? graphId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves observation steering configuration (Experimental)<br/>
        /// Returns project steering or the effective user/graph steering with project fallback. This API is experimental and may change in future releases.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataObservationSteeringConfig>> RetrievesObservationSteeringConfigurationExperimentalAsResponseAsync(
            string? userId = default,
            string? graphId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}