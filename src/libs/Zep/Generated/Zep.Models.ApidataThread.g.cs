
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThread" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="projectUuid"></param>
        /// <param name="threadId"></param>
        /// <param name="userId"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThread(
            string? createdAt,
            string? projectUuid,
            string? threadId,
            string? userId,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.ProjectUuid = projectUuid;
            this.ThreadId = threadId;
            this.UserId = userId;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThread" /> class.
        /// </summary>
        public ApidataThread()
        {
        }
    }
}