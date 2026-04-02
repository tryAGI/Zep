#nullable enable

namespace Zep
{
    public partial interface ISubpackageCommunityClient
    {
        /// <summary>
        /// Get Graph Communities (Experimental)<br/>
        /// Returns read-only community nodes for a graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>> GetGraphCommunitiesExperimentalAsync(
            string graphId,

            global::Zep.ApidataGraphCommunitiesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Graph Communities (Experimental)<br/>
        /// Returns read-only community nodes for a graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>> GetGraphCommunitiesExperimentalAsync(
            string graphId,
            int? limit = default,
            string? uuidCursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}