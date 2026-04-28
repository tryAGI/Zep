
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
        /// LastSummarizedAt is the timestamp of the most recent summary update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_summarized_at")]
        public string? LastSummarizedAt { get; set; }

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
        /// UUID of the thread summary node.
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
        /// LastSummarizedAt is the timestamp of the most recent summary update.
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
        /// UUID of the thread summary node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadSummary(
            string? createdAt,
            string? lastSummarizedAt,
            string? summary,
            string? threadId,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.LastSummarizedAt = lastSummarizedAt;
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