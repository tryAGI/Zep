#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Delete Custom Instructions<br/>
        /// Deletes custom instructions for graphs or project wide defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteCustomInstructionsAsync(

            global::Zep.ApidataDeleteCustomInstructionsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Custom Instructions<br/>
        /// Deletes custom instructions for graphs or project wide defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataSuccessResponse>> DeleteCustomInstructionsAsResponseAsync(

            global::Zep.ApidataDeleteCustomInstructionsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Custom Instructions<br/>
        /// Deletes custom instructions for graphs or project wide defaults.
        /// </summary>
        /// <param name="graphIds">
        /// Determines which group graphs will have their custom instructions deleted. If no graphs are provided, the project-wide custom instructions will be affected.
        /// </param>
        /// <param name="instructionNames">
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </param>
        /// <param name="userIds">
        /// Determines which user graphs will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be affected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteCustomInstructionsAsync(
            global::System.Collections.Generic.IList<string>? graphIds = default,
            global::System.Collections.Generic.IList<string>? instructionNames = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}