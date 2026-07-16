
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiAddNodesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// The nodes to add. 1 to 100 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zep.GraphitiAddNodeItem> Nodes { get; set; }

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
        /// Initializes a new instance of the <see cref="GraphitiAddNodesRequest" /> class.
        /// </summary>
        /// <param name="nodes">
        /// The nodes to add. 1 to 100 items.
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddNodesRequest(
            global::System.Collections.Generic.IList<global::Zep.GraphitiAddNodeItem> nodes,
            string? graphId,
            string? userId)
        {
            this.GraphId = graphId;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddNodesRequest" /> class.
        /// </summary>
        public GraphitiAddNodesRequest()
        {
        }

    }
}