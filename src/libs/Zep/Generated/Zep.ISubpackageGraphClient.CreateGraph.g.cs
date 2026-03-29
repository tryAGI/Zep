#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Create Graph<br/>
        /// Creates a new graph.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> CreateGraphAsync(

            global::Zep.ApidataCreateGraphRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Graph<br/>
        /// Creates a new graph.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="graphId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraph> CreateGraphAsync(
            string graphId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}