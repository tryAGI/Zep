#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Update Edge<br/>
        /// Updates an entity edge by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityEdge> UpdateEdgeAsync(
            string uuid,

            global::Zep.ApidataUpdateEdgeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Edge<br/>
        /// Updates an entity edge by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.GraphitiEntityEdge>> UpdateEdgeAsResponseAsync(
            string uuid,

            global::Zep.ApidataUpdateEdgeRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Edge<br/>
        /// Updates an entity edge by UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="attributes">
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </param>
        /// <param name="expiredAt">
        /// Updated time at which the edge expires
        /// </param>
        /// <param name="fact">
        /// Updated fact for the edge
        /// </param>
        /// <param name="invalidAt">
        /// Updated time at which the fact stopped being true
        /// </param>
        /// <param name="name">
        /// Updated name (relationship type) for the edge
        /// </param>
        /// <param name="validAt">
        /// Updated time at which the fact becomes true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityEdge> UpdateEdgeAsync(
            string uuid,
            object? attributes = default,
            string? expiredAt = default,
            string? fact = default,
            string? invalidAt = default,
            string? name = default,
            string? validAt = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}