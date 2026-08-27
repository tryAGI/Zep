
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GraphitiAddTripleResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge")]
        public global::Zep.GraphitiEntityEdge? Edge { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node")]
        public global::Zep.GraphitiEntityNode? SourceNode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node")]
        public global::Zep.GraphitiEntityNode? TargetNode { get; set; }

        /// <summary>
        /// Task ID of the add triple task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddTripleResponse" /> class.
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="sourceNode"></param>
        /// <param name="targetNode"></param>
        /// <param name="taskId">
        /// Task ID of the add triple task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddTripleResponse(
            global::Zep.GraphitiEntityEdge? edge,
            global::Zep.GraphitiEntityNode? sourceNode,
            global::Zep.GraphitiEntityNode? targetNode,
            string? taskId)
        {
            this.Edge = edge;
            this.SourceNode = sourceNode;
            this.TargetNode = targetNode;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddTripleResponse" /> class.
        /// </summary>
        public GraphitiAddTripleResponse()
        {
        }

    }
}