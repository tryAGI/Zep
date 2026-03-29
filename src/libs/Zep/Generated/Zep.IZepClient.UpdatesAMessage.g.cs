#nullable enable

namespace Zep
{
    public partial interface IZepClient
    {
        /// <summary>
        /// Updates a message.<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="messageUUID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadMessage> UpdatesAMessageAsync(
            string messageUUID,

            global::Zep.ModelsThreadMessageUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a message.<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="messageUUID"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadMessage> UpdatesAMessageAsync(
            string messageUUID,
            object metadata,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}