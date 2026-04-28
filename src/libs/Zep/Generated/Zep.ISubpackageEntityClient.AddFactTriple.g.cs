#nullable enable

namespace Zep
{
    public partial interface ISubpackageEntityClient
    {
        /// <summary>
        /// Add Fact Triple<br/>
        /// Add a fact triple for a user or group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiAddTripleResponse> AddFactTripleAsync(

            global::Zep.GraphitiAddTripleRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Fact Triple<br/>
        /// Add a fact triple for a user or group
        /// </summary>
        /// <param name="createdAt">
        /// The timestamp of the message
        /// </param>
        /// <param name="edgeAttributes">
        /// Additional attributes of the edge. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="expiredAt">
        /// The time (if any) at which the edge expires
        /// </param>
        /// <param name="fact">
        /// The fact relating the two nodes that this edge represents
        /// </param>
        /// <param name="factName">
        /// The name of the edge to add. Should be all caps using snake case (eg RELATES_TO)
        /// </param>
        /// <param name="factUuid">
        /// The uuid of the edge to add
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="invalidAt">
        /// The time (if any) at which the fact stops being true
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs for the shadow episode created for this fact triple.<br/>
        /// Max 10 keys. Values must be strings, numbers, or booleans.
        /// </param>
        /// <param name="sourceNodeAttributes">
        /// Additional attributes of the source node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="sourceNodeLabels">
        /// The labels for the source node
        /// </param>
        /// <param name="sourceNodeName">
        /// The name of the source node to add
        /// </param>
        /// <param name="sourceNodeSummary">
        /// The summary of the source node to add
        /// </param>
        /// <param name="sourceNodeUuid">
        /// The source node uuid
        /// </param>
        /// <param name="targetNodeAttributes">
        /// Additional attributes of the target node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="targetNodeLabels">
        /// The labels for the target node
        /// </param>
        /// <param name="targetNodeName">
        /// The name of the target node to add
        /// </param>
        /// <param name="targetNodeSummary">
        /// The summary of the target node to add
        /// </param>
        /// <param name="targetNodeUuid">
        /// The target node uuid
        /// </param>
        /// <param name="userId"></param>
        /// <param name="validAt">
        /// The time at which the fact becomes true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiAddTripleResponse> AddFactTripleAsync(
            string fact,
            string factName,
            string? createdAt = default,
            object? edgeAttributes = default,
            string? expiredAt = default,
            string? factUuid = default,
            string? graphId = default,
            string? invalidAt = default,
            object? metadata = default,
            object? sourceNodeAttributes = default,
            global::System.Collections.Generic.IList<string>? sourceNodeLabels = default,
            string? sourceNodeName = default,
            string? sourceNodeSummary = default,
            string? sourceNodeUuid = default,
            object? targetNodeAttributes = default,
            global::System.Collections.Generic.IList<string>? targetNodeLabels = default,
            string? targetNodeName = default,
            string? targetNodeSummary = default,
            string? targetNodeUuid = default,
            string? userId = default,
            string? validAt = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}