#nullable enable

namespace Zep
{
    public partial interface IUserGroupClient
    {
        /// <summary>
        /// List Users eligible to join a UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUserGroupMembersResponse> ListMemberCandidatesAsync(
            string groupUUID,
            string projectId,
            int pageNumber,
            int pageSize,
            string? search = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Users eligible to join a UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUserGroupMembersResponse>> ListMemberCandidatesAsResponseAsync(
            string groupUUID,
            string projectId,
            int pageNumber,
            int pageSize,
            string? search = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}