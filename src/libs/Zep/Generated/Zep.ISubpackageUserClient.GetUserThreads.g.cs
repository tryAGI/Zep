#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Get User Threads<br/>
        /// Returns all threads for a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataThread>> GetUserThreadsAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}