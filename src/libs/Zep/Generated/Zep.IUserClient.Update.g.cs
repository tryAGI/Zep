#nullable enable

namespace Zep
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Update User<br/>
        /// Updates a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUser> UpdateAsync(
            string userId,

            global::Zep.ApidataUpdateUserRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User<br/>
        /// Updates a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUser>> UpdateAsResponseAsync(
            string userId,

            global::Zep.ApidataUpdateUserRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User<br/>
        /// Updates a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="disableDefaultOntology">
        /// When true, disables the use of default/fallback ontology for the user's graph.
        /// </param>
        /// <param name="email">
        /// The email address of the user.
        /// </param>
        /// <param name="firstName">
        /// The first name of the user.
        /// </param>
        /// <param name="lastName">
        /// The last name of the user.
        /// </param>
        /// <param name="metadata">
        /// The metadata to update
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUser> UpdateAsync(
            string userId,
            bool? disableDefaultOntology = default,
            string? email = default,
            string? firstName = default,
            string? lastName = default,
            object? metadata = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}