#nullable enable

namespace Zep
{
    public partial interface ISubpackageGraphClient
    {
        /// <summary>
        /// List all graphs.<br/>
        /// Returns all graphs. In order to list users, use user.list_ordered instead
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphListResponse> ListAllGraphsAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? orderBy = default,
            bool? asc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}