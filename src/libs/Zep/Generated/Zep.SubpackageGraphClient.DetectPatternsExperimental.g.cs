
#nullable enable

namespace Zep
{
    public partial class SubpackageGraphClient
    {
        partial void PrepareDetectPatternsExperimentalArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Zep.ApidataDetectPatternsRequest request);
        partial void PrepareDetectPatternsExperimentalRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Zep.ApidataDetectPatternsRequest request);
        partial void ProcessDetectPatternsExperimentalResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDetectPatternsExperimentalResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Detect Patterns (Experimental)<br/>
        /// Detects structural patterns in a knowledge graph including relationship frequencies,<br/>
        /// multi-hop paths, co-occurrences, hubs, and clusters.<br/>
        /// When a query is provided, uses hybrid search to discover seed nodes,<br/>
        /// detects triple-frequency patterns, and returns resolved edges ranked by relevance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.ApidataDetectPatternsResponse> DetectPatternsExperimentalAsync(

            global::Zep.ApidataDetectPatternsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDetectPatternsExperimentalArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Zep.PathBuilder(
                path: "/graph/patterns",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareDetectPatternsExperimentalRequest(
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
            ProcessDetectPatternsExperimentalResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Zep.ApidataAPIError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Zep.ApidataAPIError.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Zep.ApidataAPIError.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Zep.ApiException<global::Zep.ApidataAPIError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::Zep.ApidataAPIError? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Zep.ApidataAPIError.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::Zep.ApidataAPIError.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Zep.ApiException<global::Zep.ApidataAPIError>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Zep.ApidataAPIError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Zep.ApidataAPIError.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Zep.ApidataAPIError.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Zep.ApiException<global::Zep.ApidataAPIError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::Zep.ApidataAPIError? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::Zep.ApidataAPIError.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::Zep.ApidataAPIError.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Zep.ApiException<global::Zep.ApidataAPIError>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessDetectPatternsExperimentalResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Zep.ApidataDetectPatternsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Zep.ApidataDetectPatternsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Detect Patterns (Experimental)<br/>
        /// Detects structural patterns in a knowledge graph including relationship frequencies,<br/>
        /// multi-hop paths, co-occurrences, hubs, and clusters.<br/>
        /// When a query is provided, uses hybrid search to discover seed nodes,<br/>
        /// detects triple-frequency patterns, and returns resolved edges ranked by relevance.
        /// </summary>
        /// <param name="detect">
        /// Which pattern types to detect with type-specific configuration.<br/>
        /// Omit to detect all types with defaults. Ignored when query is set.
        /// </param>
        /// <param name="edgeLimit">
        /// Max resolved edges per pattern. Default: 10, Max: 100. Only used with query.
        /// </param>
        /// <param name="graphId">
        /// Graph ID when detecting patterns on a named graph
        /// </param>
        /// <param name="limit">
        /// Max patterns to return. Default: 50, Max: 200
        /// </param>
        /// <param name="minOccurrences">
        /// Minimum occurrence count to report a pattern. Default: 2
        /// </param>
        /// <param name="query">
        /// Search query for discovering seed nodes via hybrid search.<br/>
        /// When set, forces triple-frequency detection only and enables edge resolution<br/>
        /// with cross-encoder reranking. Mutually exclusive with seeds.
        /// </param>
        /// <param name="queryLimit">
        /// Max seed nodes from search. Default: 10, Max: 50. Only used with query.
        /// </param>
        /// <param name="recencyWeight">
        /// Exponential half-life decay applied to edge created_at timestamps.<br/>
        /// Valid values: none, 7_days, 30_days, 90_days. Default: none
        /// </param>
        /// <param name="searchFilters">
        /// Filters which edges/nodes participate in pattern detection.<br/>
        /// Reuses the same filter format as /graph/search.
        /// </param>
        /// <param name="seeds">
        /// Seed selection. If omitted, analyzes the entire graph. Mutually exclusive with query.
        /// </param>
        /// <param name="userId">
        /// User ID when detecting patterns on a user graph
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.ApidataDetectPatternsResponse> DetectPatternsExperimentalAsync(
            global::Zep.ApidataDetectConfig? detect = default,
            int? edgeLimit = default,
            string? graphId = default,
            int? limit = default,
            int? minOccurrences = default,
            string? query = default,
            int? queryLimit = default,
            global::Zep.ApidataRecencyWeight? recencyWeight = default,
            global::Zep.GraphitiSearchFilters? searchFilters = default,
            global::Zep.ApidataPatternSeeds? seeds = default,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Zep.ApidataDetectPatternsRequest
            {
                Detect = detect,
                EdgeLimit = edgeLimit,
                GraphId = graphId,
                Limit = limit,
                MinOccurrences = minOccurrences,
                Query = query,
                QueryLimit = queryLimit,
                RecencyWeight = recencyWeight,
                SearchFilters = searchFilters,
                Seeds = seeds,
                UserId = userId,
            };

            return await DetectPatternsExperimentalAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}