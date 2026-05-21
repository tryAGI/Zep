
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataBatchItemDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// EpisodeUUID is the UUID of the episode that will be (or has been) created<br/>
        /// for this batch item. Populated for every item kind and always equal to<br/>
        /// SourceUUID — the underlying source row's UUID is reused as the episode<br/>
        /// UUID during processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episode_uuid")]
        public string? EpisodeUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsBatchItemKindJsonConverter))]
        public global::Zep.ModelsBatchItemKind? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_index")]
        public int? SequenceIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_uuid")]
        public string? SourceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsBatchItemStatusJsonConverter))]
        public global::Zep.ModelsBatchItemStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="ApidataBatchItemDetail" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="episodeUuid">
        /// EpisodeUUID is the UUID of the episode that will be (or has been) created<br/>
        /// for this batch item. Populated for every item kind and always equal to<br/>
        /// SourceUUID — the underlying source row's UUID is reused as the episode<br/>
        /// UUID during processing.
        /// </param>
        /// <param name="error"></param>
        /// <param name="graphId"></param>
        /// <param name="itemId"></param>
        /// <param name="kind"></param>
        /// <param name="sequenceIndex"></param>
        /// <param name="sourceUuid"></param>
        /// <param name="status"></param>
        /// <param name="threadId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchItemDetail(
            string? createdAt,
            string? episodeUuid,
            object? error,
            string? graphId,
            string? itemId,
            global::Zep.ModelsBatchItemKind? kind,
            int? sequenceIndex,
            string? sourceUuid,
            global::Zep.ModelsBatchItemStatus? status,
            string? threadId,
            string? updatedAt,
            string? userId)
        {
            this.CreatedAt = createdAt;
            this.EpisodeUuid = episodeUuid;
            this.Error = error;
            this.GraphId = graphId;
            this.ItemId = itemId;
            this.Kind = kind;
            this.SequenceIndex = sequenceIndex;
            this.SourceUuid = sourceUuid;
            this.Status = status;
            this.ThreadId = threadId;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchItemDetail" /> class.
        /// </summary>
        public ApidataBatchItemDetail()
        {
        }

    }
}