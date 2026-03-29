#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Get Graph<br/>
        /// Returns a graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> GetGraphAsync(
            string graphId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}