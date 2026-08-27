
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataThreadSummary
    {
        /// <summary>
        /// CreatedAt is when the summary node was first created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// LastSummarizedAt is the wall-clock timestamp of the most recent<br/>
        /// summary update. This is an ingestion-time watermark; for the<br/>
        /// event-time recency of the summary's content, use<br/>
        /// LastSummarizedEpisodeValidAt instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_summarized_at")]
        public string? LastSummarizedAt { get; set; }

        /// <summary>
        /// LastSummarizedEpisodeValidAt is the maximum episode reference time<br/>
        /// (valid_at) covered by the most recent summary. Use this when<br/>
        /// answering "how recent is this summary's content in event-time?".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_summarized_episode_valid_at")]
        public string? LastSummarizedEpisodeValidAt { get; set; }

        /// <summary>
        /// Summary is the incremental summary content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// ThreadID is the ID of the thread this summary belongs to.<br/>
        /// When a thread was created without an explicit thread_id, this<br/>
        /// field falls back to the thread's UUID. Clients should treat it<br/>
        /// as an opaque identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// UUID of the derived thread summary node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadSummary" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// CreatedAt is when the summary node was first created.
        /// </param>
        /// <param name="lastSummarizedAt">
        /// LastSummarizedAt is the wall-clock timestamp of the most recent<br/>
        /// summary update. This is an ingestion-time watermark; for the<br/>
        /// event-time recency of the summary's content, use<br/>
        /// LastSummarizedEpisodeValidAt instead.
        /// </param>
        /// <param name="lastSummarizedEpisodeValidAt">
        /// LastSummarizedEpisodeValidAt is the maximum episode reference time<br/>
        /// (valid_at) covered by the most recent summary. Use this when<br/>
        /// answering "how recent is this summary's content in event-time?".
        /// </param>
        /// <param name="summary">
        /// Summary is the incremental summary content.
        /// </param>
        /// <param name="threadId">
        /// ThreadID is the ID of the thread this summary belongs to.<br/>
        /// When a thread was created without an explicit thread_id, this<br/>
        /// field falls back to the thread's UUID. Clients should treat it<br/>
        /// as an opaque identifier.
        /// </param>
        /// <param name="uuid">
        /// UUID of the derived thread summary node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadSummary(
            string? createdAt,
            string? lastSummarizedAt,
            string? lastSummarizedEpisodeValidAt,
            string? summary,
            string? threadId,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.LastSummarizedAt = lastSummarizedAt;
            this.LastSummarizedEpisodeValidAt = lastSummarizedEpisodeValidAt;
            this.Summary = summary;
            this.ThreadId = threadId;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadSummary" /> class.
        /// </summary>
        public ApidataThreadSummary()
        {
        }

    }
}