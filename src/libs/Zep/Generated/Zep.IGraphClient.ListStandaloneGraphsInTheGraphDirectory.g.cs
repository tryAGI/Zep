#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// List standalone graphs in the graph directory<br/>
        /// Returns a paginated directory of live standalone graphs in the<br/>
        /// authenticated project. Optional `search` matches `graph_id`, `name`, and<br/>
        /// `description` (metadata only; not graph contents).<br/>
        /// Default `pageSize` is 50 (range 1–100). To list users, use<br/>
        /// `user.list_ordered` instead. See the<br/>
        /// [graph directory guide](/graph-directory) for pagination, relevance<br/>
        /// ordering, and Memory MCP exposure.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphListResponse> ListStandaloneGraphsInTheGraphDirectoryAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? search = default,
            string? orderBy = default,
            bool? asc = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List standalone graphs in the graph directory<br/>
        /// Returns a paginated directory of live standalone graphs in the<br/>
        /// authenticated project. Optional `search` matches `graph_id`, `name`, and<br/>
        /// `description` (metadata only; not graph contents).<br/>
        /// Default `pageSize` is 50 (range 1–100). To list users, use<br/>
        /// `user.list_ordered` instead. See the<br/>
        /// [graph directory guide](/graph-directory) for pagination, relevance<br/>
        /// ordering, and Memory MCP exposure.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="orderBy"></param>
        /// <param name="asc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphListResponse>> ListStandaloneGraphsInTheGraphDirectoryAsResponseAsync(
            int? pageNumber = default,
            int? pageSize = default,
            string? search = default,
            string? orderBy = default,
            bool? asc = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}