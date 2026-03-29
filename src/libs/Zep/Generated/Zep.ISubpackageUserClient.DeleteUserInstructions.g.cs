#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Delete User Instructions<br/>
        /// Deletes user summary/instructions for users or project wide defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteUserInstructionsAsync(

            global::Zep.ApidataDeleteUserInstructionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User Instructions<br/>
        /// Deletes user summary/instructions for users or project wide defaults.
        /// </summary>
        /// <param name="instructionNames">
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </param>
        /// <param name="userIds">
        /// Determines which users will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be effected.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteUserInstructionsAsync(
            global::System.Collections.Generic.IList<string>? instructionNames = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}