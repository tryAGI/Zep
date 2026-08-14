
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphEpisode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Optional document ID, will be present if the episode is part of a document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed")]
        public bool? Processed { get; set; }

        /// <summary>
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance")]
        public double? Relevance { get; set; }

        /// <summary>
        /// Optional role, will only be present if the episode was created using memory.add API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Optional role_type, will only be present if the episode was created using memory.add API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ApidataRoleTypeJsonConverter))]
        public global::Zep.ApidataRoleType? RoleType { get; set; }

        /// <summary>
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_rank")]
        public int? SelectionRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsGraphDataTypeJsonConverter))]
        public global::Zep.ModelsGraphDataType? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_description")]
        public string? SourceDescription { get; set; }

        /// <summary>
        /// Optional task ID to poll episode processing status. Currently only available for batch ingestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Optional thread ID, will be present if the episode is part of a thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisode" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="createdAt"></param>
        /// <param name="uuid"></param>
        /// <param name="documentId">
        /// Optional document ID, will be present if the episode is part of a document
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="processed"></param>
        /// <param name="relevance">
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </param>
        /// <param name="role">
        /// Optional role, will only be present if the episode was created using memory.add API
        /// </param>
        /// <param name="roleType">
        /// Optional role_type, will only be present if the episode was created using memory.add API
        /// </param>
        /// <param name="score">
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </param>
        /// <param name="selectionRank">
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </param>
        /// <param name="source"></param>
        /// <param name="sourceDescription"></param>
        /// <param name="taskId">
        /// Optional task ID to poll episode processing status. Currently only available for batch ingestion.
        /// </param>
        /// <param name="threadId">
        /// Optional thread ID, will be present if the episode is part of a thread
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphEpisode(
            string content,
            string createdAt,
            string uuid,
            string? documentId,
            object? metadata,
            bool? processed,
            double? relevance,
            string? role,
            global::Zep.ApidataRoleType? roleType,
            double? score,
            int? selectionRank,
            global::Zep.ModelsGraphDataType? source,
            string? sourceDescription,
            string? taskId,
            string? threadId)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DocumentId = documentId;
            this.Metadata = metadata;
            this.Processed = processed;
            this.Relevance = relevance;
            this.Role = role;
            this.RoleType = roleType;
            this.Score = score;
            this.SelectionRank = selectionRank;
            this.Source = source;
            this.SourceDescription = sourceDescription;
            this.TaskId = taskId;
            this.ThreadId = threadId;
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisode" /> class.
        /// </summary>
        public ApidataGraphEpisode()
        {
        }

    }
}