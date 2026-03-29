#nullable enable

namespace Zep
{
    public partial interface ISubpackageEntityClient
    {
        /// <summary>
        /// Get Edge<br/>
        /// Returns a specific edge by its UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityEdge> GetEdgeAsync(
            string uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}