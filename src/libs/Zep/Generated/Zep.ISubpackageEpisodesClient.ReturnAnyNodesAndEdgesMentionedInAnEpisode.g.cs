#nullable enable

namespace Zep
{
    public partial interface ISubpackageEpisodesClient
    {
        /// <summary>
        /// Return any nodes and edges mentioned in an episode<br/>
        /// Returns nodes and edges mentioned in an episode
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataEpisodeMentions> ReturnAnyNodesAndEdgesMentionedInAnEpisodeAsync(
            string uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}