#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Warm User Cache<br/>
        /// Hints Zep to warm a user's graph for low-latency search
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> WarmUserCacheAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}