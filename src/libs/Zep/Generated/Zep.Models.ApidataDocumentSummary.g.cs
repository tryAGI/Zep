
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataDocumentSummary
    {
        /// <summary>
        /// CreatedAt is when the summary node was first created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// DocumentID is the customer-facing document identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// LastSummarizedAt is the wall-clock timestamp of the most recent<br/>
        /// summary update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_summarized_at")]
        public string? LastSummarizedAt { get; set; }

        /// <summary>
        /// LastSummarizedEpisodeValidAt is the maximum episode reference time<br/>
        /// (valid_at) covered by the most recent summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_summarized_episode_valid_at")]
        public string? LastSummarizedEpisodeValidAt { get; set; }

        /// <summary>
        /// Summary is the incremental summary content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// UUID of the document summary (derived) node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDocumentSummary" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// CreatedAt is when the summary node was first created.
        /// </param>
        /// <param name="documentId">
        /// DocumentID is the customer-facing document identifier.
        /// </param>
        /// <param name="lastSummarizedAt">
        /// LastSummarizedAt is the wall-clock timestamp of the most recent<br/>
        /// summary update.
        /// </param>
        /// <param name="lastSummarizedEpisodeValidAt">
        /// LastSummarizedEpisodeValidAt is the maximum episode reference time<br/>
        /// (valid_at) covered by the most recent summary.
        /// </param>
        /// <param name="summary">
        /// Summary is the incremental summary content.
        /// </param>
        /// <param name="uuid">
        /// UUID of the document summary (derived) node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDocumentSummary(
            string? createdAt,
            string? documentId,
            string? lastSummarizedAt,
            string? lastSummarizedEpisodeValidAt,
            string? summary,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.DocumentId = documentId;
            this.LastSummarizedAt = lastSummarizedAt;
            this.LastSummarizedEpisodeValidAt = lastSummarizedEpisodeValidAt;
            this.Summary = summary;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDocumentSummary" /> class.
        /// </summary>
        public ApidataDocumentSummary()
        {
        }

    }
}