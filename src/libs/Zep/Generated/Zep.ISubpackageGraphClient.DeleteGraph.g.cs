#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// Delete Graph<br/>
        /// Deletes a graph. If you would like to delete a user graph, make sure to use user.delete instead.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteGraphAsync(
            string graphId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}