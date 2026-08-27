
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataBatchAddItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsGraphDataTypeJsonConverter))]
        public global::Zep.ModelsGraphDataType? DataType { get; set; }

        /// <summary>
        /// Optional document ID for graph_episode items. Groups episodes as document<br/>
        /// chunks. Ignored for thread_message items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ApidataRoleTypeJsonConverter))]
        public global::Zep.ApidataRoleType? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_description")]
        public string? SourceDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsBatchItemKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.ModelsBatchItemKind Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchAddItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="createdAt"></param>
        /// <param name="data"></param>
        /// <param name="dataType"></param>
        /// <param name="documentId">
        /// Optional document ID for graph_episode items. Groups episodes as document<br/>
        /// chunks. Ignored for thread_message items.
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="sourceDescription"></param>
        /// <param name="threadId"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchAddItem(
            global::Zep.ModelsBatchItemKind type,
            string? content,
            string? createdAt,
            string? data,
            global::Zep.ModelsGraphDataType? dataType,
            string? documentId,
            string? graphId,
            object? metadata,
            string? name,
            global::Zep.ApidataRoleType? role,
            string? sourceDescription,
            string? threadId,
            string? userId)
        {
            this.Content = content;
            this.CreatedAt = createdAt;
            this.Data = data;
            this.DataType = dataType;
            this.DocumentId = documentId;
            this.GraphId = graphId;
            this.Metadata = metadata;
            this.Name = name;
            this.Role = role;
            this.SourceDescription = sourceDescription;
            this.ThreadId = threadId;
            this.Type = type;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchAddItem" /> class.
        /// </summary>
        public ApidataBatchAddItem()
        {
        }

    }
}