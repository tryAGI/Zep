
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataAddDataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Optional document ID that groups episodes as chunks of the same document<br/>
        /// on a graph. Parallel to thread_id for message threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs. Max 10 keys. Values must be strings, numbers, booleans, or arrays of scalars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_description")]
        public string? SourceDescription { get; set; }

        /// <summary>
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_ontology")]
        public bool? StrictOntology { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsGraphDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.ModelsGraphDataType Type { get; set; }

        /// <summary>
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddDataRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="documentId">
        /// Optional document ID that groups episodes as chunks of the same document<br/>
        /// on a graph. Parallel to thread_id for message threads.
        /// </param>
        /// <param name="graphId">
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs. Max 10 keys. Values must be strings, numbers, booleans, or arrays of scalars.
        /// </param>
        /// <param name="sourceDescription"></param>
        /// <param name="strictOntology">
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </param>
        /// <param name="userId">
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAddDataRequest(
            string data,
            global::Zep.ModelsGraphDataType type,
            string? createdAt,
            string? documentId,
            string? graphId,
            object? metadata,
            string? sourceDescription,
            bool? strictOntology,
            string? userId)
        {
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.DocumentId = documentId;
            this.GraphId = graphId;
            this.Metadata = metadata;
            this.SourceDescription = sourceDescription;
            this.StrictOntology = strictOntology;
            this.Type = type;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddDataRequest" /> class.
        /// </summary>
        public ApidataAddDataRequest()
        {
        }

    }
}