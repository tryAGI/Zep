#nullable enable

namespace Zep
{
    public partial interface IGraphClient
    {
        /// <summary>
        /// Set graph ontology<br/>
        /// Sets custom entity and edge types for your graph. This wrapper method<br/>
        /// provides a clean interface for defining your graph schema with custom<br/>
        /// entity and edge types.<br/>
        /// See the [full documentation](/customizing-graph-structure#setting-entity-and-edge-types) for details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> SetOntologyAsync(

            global::Zep.SetOntologyRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set graph ontology<br/>
        /// Sets custom entity and edge types for your graph. This wrapper method<br/>
        /// provides a clean interface for defining your graph schema with custom<br/>
        /// entity and edge types.<br/>
        /// See the [full documentation](/customizing-graph-structure#setting-entity-and-edge-types) for details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.AutoSDKHttpResponse<global::Zep.ApidataSuccessResponse>> SetOntologyAsResponseAsync(

            global::Zep.SetOntologyRequest request,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set graph ontology<br/>
        /// Sets custom entity and edge types for your graph. This wrapper method<br/>
        /// provides a clean interface for defining your graph schema with custom<br/>
        /// entity and edge types.<br/>
        /// See the [full documentation](/customizing-graph-structure#setting-entity-and-edge-types) for details.
        /// </summary>
        /// <param name="entities">
        /// Dictionary mapping entity type names to their definitions
        /// </param>
        /// <param name="edges">
        /// Dictionary mapping edge type names to their definitions with source/target constraints
        /// </param>
        /// <param name="userIds">
        /// Optional list of user IDs to apply ontology to
        /// </param>
        /// <param name="graphIds">
        /// Optional list of graph IDs to apply ontology to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> SetOntologyAsync(
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEntities? entities = default,
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEdges? edges = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? graphIds = default,
            global::Zep.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}