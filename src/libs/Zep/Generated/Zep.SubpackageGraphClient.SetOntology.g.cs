
#nullable enable

namespace Zep
{
    public partial class SubpackageGraphClient
    {
        partial void PrepareSetOntologyArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Zep.SetOntologyRequest request);
        partial void PrepareSetOntologyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Zep.SetOntologyRequest request);
        partial void ProcessSetOntologyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSetOntologyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set graph ontology<br/>
        /// Sets custom entity and edge types for your graph. This wrapper method<br/>
        /// provides a clean interface for defining your graph schema with custom<br/>
        /// entity and edge types.<br/>
        /// See the [full documentation](/customizing-graph-structure#setting-entity-and-edge-types) for details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> SetOntologyAsync(

            global::Zep.SetOntologyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSetOntologyArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Zep.PathBuilder(
                path: "/graph/set-ontology",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSetOntologyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSetOntologyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSetOntologyResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Zep.ApidataSuccessResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Zep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Zep.ApidataSuccessResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Zep.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.ApidataSuccessResponse> SetOntologyAsync(
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEntities? entities = default,
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEdges? edges = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? graphIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::Zep.SetOntologyRequest
            {
                Entities = entities,
                Edges = edges,
                UserIds = userIds,
                GraphIds = graphIds,
            };

            return await SetOntologyAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}