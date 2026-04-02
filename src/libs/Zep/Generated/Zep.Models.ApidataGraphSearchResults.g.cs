
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphSearchResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("communities")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>? Communities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>? Episodes { get; set; }

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
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResults" /> class.
        /// </summary>
        /// <param name="communities"></param>
        /// <param name="edges"></param>
        /// <param name="episodes"></param>
        /// <param name="nodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphSearchResults(
            global::System.Collections.Generic.IList<global::Zep.GraphitiCommunityNode>? communities,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>? episodes,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? nodes)
        {
            this.Communities = communities;
            this.Edges = edges;
            this.Episodes = episodes;
            this.Nodes = nodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResults" /> class.
        /// </summary>
        public ApidataGraphSearchResults()
        {
        }
    }
}