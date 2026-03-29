#nullable enable

namespace Zep
{
    public partial interface ISubpackageThreadClient
    {
        /// <summary>
        /// Delete thread<br/>
        /// Deletes a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> DeleteThreadAsync(
            string threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}