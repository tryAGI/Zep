#nullable enable

namespace Zep
{
    public partial interface ISubpackageEntityClient
    {
        /// <summary>
        /// Get Entity Edges for a node<br/>
        /// Returns all edges for a node
        /// </summary>
        /// <param name="nodeUuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>> GetEntityEdgesForANodeAsync(
            string nodeUuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}