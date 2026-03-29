#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Update Graph.<br/>
        /// Updates information about a graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> UpdateGraphAsync(
            string graphId,

            global::Zep.ApidataUpdateGraphRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Graph.<br/>
        /// Updates information about a graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> UpdateGraphAsync(
            string graphId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}