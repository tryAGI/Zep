#nullable enable

namespace Zep
{
    public partial interface ISubpackageUserClient
    {
        /// <summary>
        /// Get Users<br/>
        /// Returns all users.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserListResponse> ListOrderedAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? search = default,
            string? orderBy = default,
            bool? asc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}