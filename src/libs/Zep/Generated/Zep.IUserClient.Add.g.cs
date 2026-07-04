#nullable enable

namespace Zep
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Add User<br/>
        /// Adds a user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUser> AddAsync(

            global::Zep.ApidataCreateUserRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User<br/>
        /// Adds a user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataUser>> AddAsResponseAsync(

            global::Zep.ApidataCreateUserRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User<br/>
        /// Adds a user.
        /// </summary>
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
        /// The metadata associated with the user.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataUser> AddAsync(
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