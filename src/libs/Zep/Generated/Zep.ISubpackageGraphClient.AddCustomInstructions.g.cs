#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Add Custom Instructions<br/>
        /// Adds new custom instructions for graphs without removing existing ones. If user_ids or graph_ids is empty, adds to project-wide default instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> AddCustomInstructionsAsync(

            global::Zep.ApidataAddCustomInstructionsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Custom Instructions<br/>
        /// Adds new custom instructions for graphs without removing existing ones. If user_ids or graph_ids is empty, adds to project-wide default instructions.
        /// </summary>
        /// <param name="graphIds">
        /// Graph IDs to add the instructions to. If empty, the instructions are added to the project-wide default.
        /// </param>
        /// <param name="instructions">
        /// Instructions to add to the graph.
        /// </param>
        /// <param name="userIds">
        /// User IDs to add the instructions to. If empty, the instructions are added to the project-wide default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> AddCustomInstructionsAsync(
            global::System.Collections.Generic.IList<global::Zep.ApidataCustomInstruction> instructions,
            global::System.Collections.Generic.IList<string>? graphIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}