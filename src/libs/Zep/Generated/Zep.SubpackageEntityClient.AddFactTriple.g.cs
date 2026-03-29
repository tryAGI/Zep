
#nullable enable

namespace Zep
{
    public partial class SubpackageEntityClient
    {
        partial void PrepareAddFactTripleArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Zep.GraphitiAddTripleRequest request);
        partial void PrepareAddFactTripleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Zep.GraphitiAddTripleRequest request);
        partial void ProcessAddFactTripleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddFactTripleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Fact Triple<br/>
        /// Add a fact triple for a user or group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.GraphitiAddTripleResponse> AddFactTripleAsync(

            global::Zep.GraphitiAddTripleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddFactTripleArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Zep.PathBuilder(
                path: "/graph/add-fact-triple",
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
            PrepareAddFactTripleRequest(
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
            ProcessAddFactTripleResponse(
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
                ProcessAddFactTripleResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Zep.GraphitiAddTripleResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Zep.GraphitiAddTripleResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Zep.GraphitiAddTripleResponse> AddFactTripleAsync(
            string fact,
            string factName,
            string? createdAt = default,
            object? edgeAttributes = default,
            string? expiredAt = default,
            string? factUuid = default,
            string? graphId = default,
            string? invalidAt = default,
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Zep.GraphitiAddTripleRequest
            {
                CreatedAt = createdAt,
                EdgeAttributes = edgeAttributes,
                ExpiredAt = expiredAt,
                Fact = fact,
                FactName = factName,
                FactUuid = factUuid,
                GraphId = graphId,
                InvalidAt = invalidAt,
                SourceNodeAttributes = sourceNodeAttributes,
                SourceNodeLabels = sourceNodeLabels,
                SourceNodeName = sourceNodeName,
                SourceNodeSummary = sourceNodeSummary,
                SourceNodeUuid = sourceNodeUuid,
                TargetNodeAttributes = targetNodeAttributes,
                TargetNodeLabels = targetNodeLabels,
                TargetNodeName = targetNodeName,
                TargetNodeSummary = targetNodeSummary,
                TargetNodeUuid = targetNodeUuid,
                UserId = userId,
                ValidAt = validAt,
            };

            return await AddFactTripleAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}