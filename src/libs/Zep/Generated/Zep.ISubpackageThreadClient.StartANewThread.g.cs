#nullable enable

namespace Zep
{
    public partial interface ISubpackageThreadClient
    {
        /// <summary>
        /// Start a new thread.<br/>
        /// Start a new thread.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThread> StartANewThreadAsync(

            global::Zep.ModelsCreateThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a new thread.<br/>
        /// Start a new thread.
        /// </summary>
        /// <param name="threadId">
        /// The unique identifier of the thread.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user associated with the thread
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThread> StartANewThreadAsync(
            string threadId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}