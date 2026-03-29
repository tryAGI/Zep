
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataThreadMessageListResponse
    {
        /// <summary>
        /// A list of message objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage>? Messages { get; set; }

        /// <summary>
        /// The number of messages returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// The thread creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_created_at")]
        public string? ThreadCreatedAt { get; set; }

        /// <summary>
        /// The total number of messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The user ID associated with this thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadMessageListResponse" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of message objects.
        /// </param>
        /// <param name="rowCount">
        /// The number of messages returned.
        /// </param>
        /// <param name="threadCreatedAt">
        /// The thread creation timestamp.
        /// </param>
        /// <param name="totalCount">
        /// The total number of messages.
        /// </param>
        /// <param name="userId">
        /// The user ID associated with this thread.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadMessageListResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage>? messages,
            int? rowCount,
            string? threadCreatedAt,
            int? totalCount,
            string? userId)
        {
            this.Messages = messages;
            this.RowCount = rowCount;
            this.ThreadCreatedAt = threadCreatedAt;
            this.TotalCount = totalCount;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadMessageListResponse" /> class.
        /// </summary>
        public ApidataThreadMessageListResponse()
        {
        }
    }
}