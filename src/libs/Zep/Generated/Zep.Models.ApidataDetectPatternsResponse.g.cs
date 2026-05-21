
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataDetectPatternsResponse
    {
        /// <summary>
        /// Statistics about the detection run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Zep.ApidataPatternMetadata? Metadata { get; set; }

        /// <summary>
        /// Resolved nodes referenced by pattern edges (deduplicated). Only populated when query is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? Nodes { get; set; }

        /// <summary>
        /// Detected patterns, sorted by weighted_score descending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataPatternResult>? Patterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectPatternsResponse" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Statistics about the detection run
        /// </param>
        /// <param name="nodes">
        /// Resolved nodes referenced by pattern edges (deduplicated). Only populated when query is set.
        /// </param>
        /// <param name="patterns">
        /// Detected patterns, sorted by weighted_score descending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDetectPatternsResponse(
            global::Zep.ApidataPatternMetadata? metadata,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEntityNode>? nodes,
            global::System.Collections.Generic.IList<global::Zep.ApidataPatternResult>? patterns)
        {
            this.Metadata = metadata;
            this.Nodes = nodes;
            this.Patterns = patterns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectPatternsResponse" /> class.
        /// </summary>
        public ApidataDetectPatternsResponse()
        {
        }

    }
}