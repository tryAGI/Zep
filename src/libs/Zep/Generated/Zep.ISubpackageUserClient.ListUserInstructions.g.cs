#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// List User Instructions<br/>
        /// Lists all user summary instructions for a project, user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataListUserInstructionsResponse> ListUserInstructionsAsync(
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}