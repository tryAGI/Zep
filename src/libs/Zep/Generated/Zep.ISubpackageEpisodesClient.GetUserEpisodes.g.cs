#nullable enable

namespace Zep
{
    public partial interface ISubpackageEpisodesClient
    {
        /// <summary>
        /// Get User Episodes<br/>
        /// Returns episodes by user id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lastn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetUserEpisodesAsync(
            string userId,
            int? lastn = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}