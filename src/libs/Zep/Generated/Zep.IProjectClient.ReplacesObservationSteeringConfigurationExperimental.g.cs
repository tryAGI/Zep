#nullable enable

namespace Zep
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Replaces observation steering configuration (Experimental)<br/>
        /// Replaces project, user, or graph steering. An empty configuration clears the project default or removes the user/graph override. Changes affect later materializer runs only. This API is experimental and may change in future releases.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataObservationSteeringConfig> ReplacesObservationSteeringConfigurationExperimentalAsync(

            global::Zep.ApidataObservationSteeringConfig request,
            string? userId = default,
            string? graphId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces observation steering configuration (Experimental)<br/>
        /// Replaces project, user, or graph steering. An empty configuration clears the project default or removes the user/graph override. Changes affect later materializer runs only. This API is experimental and may change in future releases.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataObservationSteeringConfig>> ReplacesObservationSteeringConfigurationExperimentalAsResponseAsync(

            global::Zep.ApidataObservationSteeringConfig request,
            string? userId = default,
            string? graphId = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces observation steering configuration (Experimental)<br/>
        /// Replaces project, user, or graph steering. An empty configuration clears the project default or removes the user/graph override. Changes affect later materializer runs only. This API is experimental and may change in future releases.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="graphId"></param>
        /// <param name="instruction"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataObservationSteeringConfig> ReplacesObservationSteeringConfigurationExperimentalAsync(
            string? userId = default,
            string? graphId = default,
            string? instruction = default,
            global::System.Collections.Generic.IList<global::Zep.ApidataObservationType>? types = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}