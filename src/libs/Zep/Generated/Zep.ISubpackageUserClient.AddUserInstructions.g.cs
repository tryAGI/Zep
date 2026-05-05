#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Add User Instructions<br/>
        /// Adds new summary instructions for users graphs without removing existing ones. If user_ids is empty, adds to project-wide default instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> AddUserInstructionsAsync(

            global::Zep.ApidataAddUserInstructionsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User Instructions<br/>
        /// Adds new summary instructions for users graphs without removing existing ones. If user_ids is empty, adds to project-wide default instructions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataSuccessResponse>> AddUserInstructionsAsResponseAsync(

            global::Zep.ApidataAddUserInstructionsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User Instructions<br/>
        /// Adds new summary instructions for users graphs without removing existing ones. If user_ids is empty, adds to project-wide default instructions.
        /// </summary>
        /// <param name="instructions">
        /// Instructions to add to the user summary generation.
        /// </param>
        /// <param name="userIds">
        /// User IDs to add the instructions to. If empty, the instructions are added to the project-wide default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> AddUserInstructionsAsync(
            global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction> instructions,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}