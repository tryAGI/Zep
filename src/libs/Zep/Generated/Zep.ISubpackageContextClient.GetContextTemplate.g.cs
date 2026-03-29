#nullable enable

namespace Zep
{
    public partial interface ISubpackageContextClient
    {
        /// <summary>
        /// Get Context Template<br/>
        /// Retrieves a context template by template_id.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataContextTemplateResponse> GetContextTemplateAsync(
            string templateId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}