
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataPatternSeeds
    {
        /// <summary>
        /// All endpoints of these edge types become seeds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_types")]
        public global::System.Collections.Generic.IList<string>? EdgeTypes { get; set; }

        /// <summary>
        /// All nodes with these labels become seeds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_labels")]
        public global::System.Collections.Generic.IList<string>? NodeLabels { get; set; }

        /// <summary>
        /// Specific node UUIDs to analyze around. Max 10000 to align with pattern detection seed limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_uuids")]
        public global::System.Collections.Generic.IList<string>? NodeUuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternSeeds" /> class.
        /// </summary>
        /// <param name="edgeTypes">
        /// All endpoints of these edge types become seeds
        /// </param>
        /// <param name="nodeLabels">
        /// All nodes with these labels become seeds
        /// </param>
        /// <param name="nodeUuids">
        /// Specific node UUIDs to analyze around. Max 10000 to align with pattern detection seed limits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataPatternSeeds(
            global::System.Collections.Generic.IList<string>? edgeTypes,
            global::System.Collections.Generic.IList<string>? nodeLabels,
            global::System.Collections.Generic.IList<string>? nodeUuids)
        {
            this.EdgeTypes = edgeTypes;
            this.NodeLabels = nodeLabels;
            this.NodeUuids = nodeUuids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPatternSeeds" /> class.
        /// </summary>
        public ApidataPatternSeeds()
        {
        }
    }
}