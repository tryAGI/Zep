
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataBatchInvalidItem
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

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
        /// Initializes a new instance of the <see cref="ApidataBatchInvalidItem" /> class.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="itemId"></param>
        /// <param name="reason"></param>
        /// <param name="sequenceIndex"></param>
        /// <param name="sourceUuid"></param>
        /// <param name="threadId"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchInvalidItem(
            string? graphId,
            string? itemId,
            string? reason,
            int? sequenceIndex,
            string? sourceUuid,
            string? threadId,
            string? userId)
        {
            this.GraphId = graphId;
            this.ItemId = itemId;
            this.Reason = reason;
            this.SequenceIndex = sequenceIndex;
            this.SourceUuid = sourceUuid;
            this.ThreadId = threadId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchInvalidItem" /> class.
        /// </summary>
        public ApidataBatchInvalidItem()
        {
        }

    }
}