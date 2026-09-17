#nullable enable

namespace Zep
{
    public partial interface IUserGroupClient
    {
        /// <summary>
        /// Remove one member from a managed UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="userUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserGroupMembershipResponse> RemoveMemberAsync(
            string groupUUID,
            string userUUID,
            string projectId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove one member from a managed UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="userUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUserGroupMembershipResponse>> RemoveMemberAsResponseAsync(
            string groupUUID,
            string userUUID,
            string projectId,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}