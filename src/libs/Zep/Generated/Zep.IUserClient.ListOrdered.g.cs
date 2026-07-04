#nullable enable

namespace Zep
{
    public partial interface IUserClient
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserListResponse> ListOrderedAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? search = default,
            string? orderBy = default,
            bool? asc = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Users<br/>
        /// Returns all users.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUserListResponse>> ListOrderedAsResponseAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? search = default,
            string? orderBy = default,
            bool? asc = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}