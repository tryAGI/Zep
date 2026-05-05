#nullable enable

namespace Zep
{
    public partial interface ISubpackageEpisodesClient
    {
        /// <summary>
        /// Update Episode Metadata<br/>
        /// Update episode metadata with merge semantics. Supplied keys overwrite or add to existing metadata; keys set to null are removed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisode> UpdateEpisodeMetadataAsync(
            string uuid,

            global::Zep.ApidataUpdateEpisodeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Episode Metadata<br/>
        /// Update episode metadata with merge semantics. Supplied keys overwrite or add to existing metadata; keys set to null are removed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataGraphEpisode>> UpdateEpisodeMetadataAsResponseAsync(
            string uuid,

            global::Zep.ApidataUpdateEpisodeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Episode Metadata<br/>
        /// Update episode metadata with merge semantics. Supplied keys overwrite or add to existing metadata; keys set to null are removed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="metadata">
        /// Updated metadata. Merged with existing metadata: supplied keys overwrite/add, keys set to null are removed. Maximum 10 keys. Values must be scalars (string, number, boolean, null) or arrays of scalars.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataGraphEpisode> UpdateEpisodeMetadataAsync(
            string uuid,
            object metadata,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}