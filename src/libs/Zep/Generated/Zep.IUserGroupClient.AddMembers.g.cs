#nullable enable

namespace Zep
{
    public partial interface IUserGroupClient
    {
        /// <summary>
        /// Add members to a managed UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserGroupMembershipResponse> AddMembersAsync(
            string groupUUID,
            string projectId,

            global::Zep.ApidataMutateUserGroupMembersRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a managed UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUserGroupMembershipResponse>> AddMembersAsResponseAsync(
            string groupUUID,
            string projectId,

            global::Zep.ApidataMutateUserGroupMembersRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add members to a managed UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="userUuids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserGroupMembershipResponse> AddMembersAsync(
            string groupUUID,
            string projectId,
            global::System.Collections.Generic.IList<string> userUuids,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}