#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// List graph ontology<br/>
        /// Retrieves the current entity and edge types configured for your graph.<br/>
        /// See the [full documentation](/customizing-graph-structure) for details.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataEntityTypeResponse> ListOntologyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}