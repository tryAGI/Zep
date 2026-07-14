#nullable enable

namespace Zep
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Updates project time-zone information<br/>
        /// Sets or clears the project-level fallback time zone for the API key's project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataProjectInfoResponse> UpdatesProjectTimeZoneInformationAsync(

            global::Zep.ApidataUpdateProjectInfoRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project time-zone information<br/>
        /// Sets or clears the project-level fallback time zone for the API key's project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataProjectInfoResponse>> UpdatesProjectTimeZoneInformationAsResponseAsync(

            global::Zep.ApidataUpdateProjectInfoRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates project time-zone information<br/>
        /// Sets or clears the project-level fallback time zone for the API key's project.
        /// </summary>
        /// <param name="defaultTimeZone">
        /// The project's IANA fallback time zone. Null clears the existing value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataProjectInfoResponse> UpdatesProjectTimeZoneInformationAsync(
            string? defaultTimeZone = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}