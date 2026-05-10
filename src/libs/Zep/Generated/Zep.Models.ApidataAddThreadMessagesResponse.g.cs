
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataAddThreadMessagesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_uuids")]
        public global::System.Collections.Generic.IList<string>? MessageUuids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddThreadMessagesResponse" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="messageUuids"></param>
        /// <param name="taskId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAddThreadMessagesResponse(
            string? context,
            global::System.Collections.Generic.IList<string>? messageUuids,
            string? taskId)
        {
            this.Context = context;
            this.MessageUuids = messageUuids;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddThreadMessagesResponse" /> class.
        /// </summary>
        public ApidataAddThreadMessagesResponse()
        {
        }

    }
}