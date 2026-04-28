
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
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiDerivedNode>? Observations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_summaries")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiSagaNode>? ThreadSummaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResults" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="edges"></param>
        /// <param name="episodes"></param>
        /// <param name="nodes"></param>
        /// <param name="observations"></param>
        /// <param name="threadSummaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphSearchResults(
            string? context,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityEdge>? edges,
            global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>? episodes,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? nodes,
            global::System.Collections.Generic.IList<global::Zep.GraphitiDerivedNode>? observations,
            global::System.Collections.Generic.IList<global::Zep.GraphitiSagaNode>? threadSummaries)
        {
            this.Context = context;
            this.Edges = edges;
            this.Episodes = episodes;
            this.Nodes = nodes;
            this.Observations = observations;
            this.ThreadSummaries = threadSummaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResults" /> class.
        /// </summary>
        public ApidataGraphSearchResults()
        {
        }
    }
}