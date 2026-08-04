#nullable enable

namespace Zep
{
    public partial interface IUserGroupClient
    {
        /// <summary>
        /// Attach a policy set to a UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataAttachedPolicySetsResponse> AttachPolicySetAsync(
            string groupUUID,
            string projectId,

            global::Zep.ApidataAttachPolicySetRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a policy set to a UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataAttachedPolicySetsResponse>> AttachPolicySetAsResponseAsync(
            string groupUUID,
            string projectId,

            global::Zep.ApidataAttachPolicySetRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach a policy set to a UserGroup
        /// </summary>
        /// <param name="groupUUID"></param>
        /// <param name="projectId"></param>
        /// <param name="policySetUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataAttachedPolicySetsResponse> AttachPolicySetAsync(
            string groupUUID,
            string projectId,
            string policySetUuid,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}