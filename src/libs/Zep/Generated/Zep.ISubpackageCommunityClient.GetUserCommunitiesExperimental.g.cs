#nullable enable

namespace Zep
{
    public partial interface ISubpackageCommunityClient
    {
        /// <summary>
        /// Get User Communities (Experimental)<br/>
        /// Returns read-only community nodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>> GetUserCommunitiesExperimentalAsync(
            string userId,

            global::Zep.ApidataGraphCommunitiesRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Communities (Experimental)<br/>
        /// Returns read-only community nodes for a user's graph.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>> GetUserCommunitiesExperimentalAsync(
            string userId,
            int? limit = default,
            string? uuidCursor = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}