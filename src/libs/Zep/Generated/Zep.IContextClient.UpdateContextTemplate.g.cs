#nullable enable

namespace Zep
{
    public partial interface IContextClient
    {
        /// <summary>
        /// Update Context Template<br/>
        /// Updates an existing context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> UpdateContextTemplateAsync(
            string templateId,

            global::Zep.ApidataUpdateContextTemplateRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Context Template<br/>
        /// Updates an existing context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataContextTemplateResponse>> UpdateContextTemplateAsResponseAsync(
            string templateId,

            global::Zep.ApidataUpdateContextTemplateRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Context Template<br/>
        /// Updates an existing context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="template">
        /// The template content (max 1200 characters).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> UpdateContextTemplateAsync(
            string templateId,
            string template,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}