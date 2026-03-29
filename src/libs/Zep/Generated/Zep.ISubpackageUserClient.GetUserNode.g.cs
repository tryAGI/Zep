#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Get User Node<br/>
        /// Returns a user's node.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserNodeResponse> GetUserNodeAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}