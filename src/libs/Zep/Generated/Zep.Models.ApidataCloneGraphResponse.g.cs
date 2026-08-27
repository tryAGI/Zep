
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataCloneGraphResponse
    {
        /// <summary>
        /// graph_id is the ID of the cloned graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// Task ID of the clone graph task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

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
        /// Initializes a new instance of the <see cref="ApidataCloneGraphResponse" /> class.
        /// </summary>
        /// <param name="graphId">
        /// graph_id is the ID of the cloned graph
        /// </param>
        /// <param name="taskId">
        /// Task ID of the clone graph task
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCloneGraphResponse(
            string? graphId,
            string? taskId,
            string? userId)
        {
            this.GraphId = graphId;
            this.TaskId = taskId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCloneGraphResponse" /> class.
        /// </summary>
        public ApidataCloneGraphResponse()
        {
        }

    }
}