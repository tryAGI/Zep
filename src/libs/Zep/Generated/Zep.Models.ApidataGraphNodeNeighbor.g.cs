
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphNodeNeighbor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public global::Zep.GraphitiEntityNode? Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphNodeNeighbor" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="node"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphNodeNeighbor(
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::Zep.GraphitiEntityNode? node)
        {
            this.Edges = edges;
            this.Node = node;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphNodeNeighbor" /> class.
        /// </summary>
        public ApidataGraphNodeNeighbor()
        {
        }

    }
}