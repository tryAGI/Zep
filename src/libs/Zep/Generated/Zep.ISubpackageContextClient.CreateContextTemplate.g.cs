#nullable enable

namespace Zep
{
    public partial interface ISubpackageContextClient
    {
        /// <summary>
        /// Create Context Template<br/>
        /// Creates a new context template.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> CreateContextTemplateAsync(

            global::Zep.ApidataCreateContextTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Context Template<br/>
        /// Creates a new context template.
        /// </summary>
        /// <param name="template">
        /// The template content (max 1200 characters).
        /// </param>
        /// <param name="templateId">
        /// Unique identifier for the template (max 100 characters).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> CreateContextTemplateAsync(
            string template,
            string templateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}