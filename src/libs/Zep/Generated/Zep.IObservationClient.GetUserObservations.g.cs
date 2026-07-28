#nullable enable

namespace Zep
{
    public partial interface IObservationClient
    {
        /// <summary>
        /// Get User Observations<br/>
        /// Returns read-only observation nodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiDerivedNode>> GetUserObservationsAsync(
            string userId,

            global::Zep.ApidataGraphObservationsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Observations<br/>
        /// Returns read-only observation nodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.GraphitiDerivedNode>>> GetUserObservationsAsResponseAsync(
            string userId,

            global::Zep.ApidataGraphObservationsRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Observations<br/>
        /// Returns read-only observation nodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor response header<br/>
        /// of the previous page. Encodes the sort field, direction, and continuation position.
        /// </param>
        /// <param name="direction">
        /// Sort direction. One of "asc" or "desc" (default "desc").
        /// </param>
        /// <param name="filters">
        /// Optional filters applied to the listed artifacts. Reuses the graph.search filter type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by. One of "created_at", "valid_at", or "uuid" (default "uuid").
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page.<br/>
        /// Deprecated: prefer Cursor, the opaque cursor returned via the Zep-Next-Cursor response header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiDerivedNode>> GetUserObservationsAsync(
            string userId,
            string? cursor = default,
            string? direction = default,
            global::Zep.GraphitiSearchFilters? filters = default,
            int? limit = default,
            string? orderBy = default,
            string? uuidCursor = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}