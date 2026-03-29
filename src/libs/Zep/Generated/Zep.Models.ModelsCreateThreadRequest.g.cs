
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsCreateThreadRequest
    {
        /// <summary>
        /// The unique identifier of the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// The unique identifier of the user associated with the thread
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateThreadRequest" /> class.
        /// </summary>
        /// <param name="threadId">
        /// The unique identifier of the thread.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user associated with the thread
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCreateThreadRequest(
            string threadId,
            string userId)
        {
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateThreadRequest" /> class.
        /// </summary>
        public ModelsCreateThreadRequest()
        {
        }
    }
}