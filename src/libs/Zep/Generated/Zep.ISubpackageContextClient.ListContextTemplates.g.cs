#nullable enable

namespace Zep
{
    public partial interface ISubpackageContextClient
    {
        /// <summary>
        /// List Context Templates<br/>
        /// Lists all context templates.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataListContextTemplatesResponse> ListContextTemplatesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}