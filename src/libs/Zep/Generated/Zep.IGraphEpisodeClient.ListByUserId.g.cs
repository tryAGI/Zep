#nullable enable

namespace Zep
{
    public partial interface IGraphEpisodeClient
    {
        /// <summary>
        /// List User Episodes<br/>
        /// Returns a paginated, filterable list of episodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> ListByUserIdAsync(
            string userId,

            global::Zep.ApidataGraphEpisodeListRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List User Episodes<br/>
        /// Returns a paginated, filterable list of episodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>>> ListByUserIdAsResponseAsync(
            string userId,

            global::Zep.ApidataGraphEpisodeListRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List User Episodes<br/>
        /// Returns a paginated, filterable list of episodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </param>
        /// <param name="direction">
        /// Sort direction. One of "asc" or "desc". Defaults to "desc".
        /// </param>
        /// <param name="episodeMetadataFilters">
        /// Restricts results to episodes whose stored metadata matches this<br/>
        /// predicate. Same type and limits as graph.search episode_metadata_filters.
        /// </param>
        /// <param name="limit">
        /// Maximum number of episodes to return. An explicit value is clamped to<br/>
        /// 50; when omitted, the default page size (100) applies.
        /// </param>
        /// <param name="mentionedNodeUuids">
        /// Restricts results to episodes that mention any of the listed node<br/>
        /// UUIDs. The list can also contain episode UUIDs: an episode UUID<br/>
        /// matches that episode, so one request can return a known set of<br/>
        /// episodes. At most 256 entries; each must be a syntactically valid UUID.
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by. One of "uuid" or "created_at". Defaults to "uuid".
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> ListByUserIdAsync(
            string userId,
            string? cursor = default,
            string? direction = default,
            global::Zep.GraphitiMetadataFilterGroup? episodeMetadataFilters = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? mentionedNodeUuids = default,
            string? orderBy = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}