
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataEpisodeMentions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? Edges { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEpisodeMentions" /> class.
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="nodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataEpisodeMentions(
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? nodes)
        {
            this.Edges = edges;
            this.Nodes = nodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEpisodeMentions" /> class.
        /// </summary>
        public ApidataEpisodeMentions()
        {
        }

    }
}