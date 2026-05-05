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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadMessage> UpdatesAMessageAsync(
            string messageUUID,

            global::Zep.ModelsThreadMessageUpdate request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a message.<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="messageUUID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataThreadMessage>> UpdatesAMessageAsResponseAsync(
            string messageUUID,

            global::Zep.ModelsThreadMessageUpdate request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a message.<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="messageUUID"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataThreadMessage> UpdatesAMessageAsync(
            string messageUUID,
            object metadata,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}