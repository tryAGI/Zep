
#nullable enable

namespace Zep
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IZepClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Zep.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Zep.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// 
        /// </summary>
        public ContextClient Context { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataClient Data { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentClient Document { get; }

        /// <summary>
        /// 
        /// </summary>
        public DocumentSummaryClient DocumentSummary { get; }

        /// <summary>
        /// 
        /// </summary>
        public EntityClient Entity { get; }

        /// <summary>
        /// 
        /// </summary>
        public EpisodesClient Episodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public GraphClient Graph { get; }

        /// <summary>
        /// 
        /// </summary>
        public GraphEpisodeClient GraphEpisode { get; }

        /// <summary>
        /// 
        /// </summary>
        public GraphNodeClient GraphNode { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObservationClient Observation { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectClient Project { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public TaskClient Task { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThreadClient Thread { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThreadSummaryClient ThreadSummary { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserGroupClient UserGroup { get; }

    }
}