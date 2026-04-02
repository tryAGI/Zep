#nullable enable

namespace Zep
{
    public partial interface ISubpackageCommunityClient
    {
        /// <summary>
        /// Get Community (Experimental)<br/>
        /// Returns a specific community node by UUID. Community nodes are read-only.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiCommunityNode> GetCommunityExperimentalAsync(
            string uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}