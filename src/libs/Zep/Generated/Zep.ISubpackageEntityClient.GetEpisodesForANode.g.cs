#nullable enable

namespace Zep
{
    public partial interface ISubpackageEntityClient
    {
        /// <summary>
        /// Get Episodes for a node<br/>
        /// Returns all episodes that mentioned a given node
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisodeResponse> GetEpisodesForANodeAsync(
            string nodeUuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}