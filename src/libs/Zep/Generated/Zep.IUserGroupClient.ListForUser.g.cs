#nullable enable

namespace Zep
{
    public partial interface IUserGroupClient
    {
        /// <summary>
        /// List effective UserGroups for a User
        /// </summary>
        /// <param name="userUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserMembershipGroupsResponse> ListForUserAsync(
            string userUUID,
            string projectId,
            string authorization,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List effective UserGroups for a User
        /// </summary>
        /// <param name="userUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUserMembershipGroupsResponse>> ListForUserAsResponseAsync(
            string userUUID,
            string projectId,
            string authorization,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}