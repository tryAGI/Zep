#nullable enable

namespace Zep
{
    public partial interface ISubpackageEpisodesClient
    {
        /// <summary>
        /// Get Graph Episodes<br/>
        /// Returns episodes by graph id.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="lastn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetGraphEpisodesAsync(
            string graphId,
            int? lastn = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}