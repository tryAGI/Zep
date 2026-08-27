
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GraphitiAddNodesResponse
    {
        /// <summary>
        /// The accepted nodes, each carrying the UUID Zep assigned to it, in request<br/>
        /// order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiAddedNode>? Nodes { get; set; }

        /// <summary>
        /// Task ID of the async add-nodes task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddNodesResponse" /> class.
        /// </summary>
        /// <param name="nodes">
        /// The accepted nodes, each carrying the UUID Zep assigned to it, in request<br/>
        /// order.
        /// </param>
        /// <param name="taskId">
        /// Task ID of the async add-nodes task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddNodesResponse(
            global::System.Collections.Generic.IList<global::Zep.GraphitiAddedNode>? nodes,
            string? taskId)
        {
            this.Nodes = nodes;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddNodesResponse" /> class.
        /// </summary>
        public GraphitiAddNodesResponse()
        {
        }

    }
}