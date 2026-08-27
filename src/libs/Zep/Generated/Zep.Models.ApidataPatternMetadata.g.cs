
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataPatternMetadata
    {
        /// <summary>
        /// Number of edges analyzed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges_analyzed")]
        public int? EdgesAnalyzed { get; set; }

        /// <summary>
        /// Elapsed time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_ms")]
        public int? ElapsedMs { get; set; }

        /// <summary>
        /// Number of unique nodes analyzed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes_analyzed")]
        public int? NodesAnalyzed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternMetadata" /> class.
        /// </summary>
        /// <param name="edgesAnalyzed">
        /// Number of edges analyzed
        /// </param>
        /// <param name="elapsedMs">
        /// Elapsed time in milliseconds
        /// </param>
        /// <param name="nodesAnalyzed">
        /// Number of unique nodes analyzed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataPatternMetadata(
            int? edgesAnalyzed,
            int? elapsedMs,
            int? nodesAnalyzed)
        {
            this.EdgesAnalyzed = edgesAnalyzed;
            this.ElapsedMs = elapsedMs;
            this.NodesAnalyzed = nodesAnalyzed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternMetadata" /> class.
        /// </summary>
        public ApidataPatternMetadata()
        {
        }

    }
}