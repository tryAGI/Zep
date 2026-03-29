#nullable enable

namespace Zep
{
    public partial interface ISubpackageContextClient
    {
        /// <summary>
        /// Update Context Template<br/>
        /// Updates an existing context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> UpdateContextTemplateAsync(
            string templateId,

            global::Zep.ApidataUpdateContextTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Context Template<br/>
        /// Updates an existing context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="template">
        /// The template content (max 1200 characters).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> UpdateContextTemplateAsync(
            string templateId,
            string template,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}