
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataDetectConfig
    {
        /// <summary>
        /// Detect tightly interconnected groups (triangle topology)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clusters")]
        public global::Zep.ApidataClusterDetectConfig? Clusters { get; set; }

        /// <summary>
        /// Detect node types that co-occur within k hops
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("co_occurrences")]
        public global::Zep.ApidataCoOccurrenceDetectConfig? CoOccurrences { get; set; }

        /// <summary>
        /// Detect highly connected hub nodes (star topology)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hubs")]
        public global::Zep.ApidataHubDetectConfig? Hubs { get; set; }

        /// <summary>
        /// Detect frequent multi-hop connection paths
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        public global::Zep.ApidataPathDetectConfig? Paths { get; set; }

        /// <summary>
        /// Detect common (source_label, edge_type, target_label) relationship triples
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::Zep.ApidataRelationshipDetectConfig? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectConfig" /> class.
        /// </summary>
        /// <param name="clusters">
        /// Detect tightly interconnected groups (triangle topology)
        /// </param>
        /// <param name="coOccurrences">
        /// Detect node types that co-occur within k hops
        /// </param>
        /// <param name="hubs">
        /// Detect highly connected hub nodes (star topology)
        /// </param>
        /// <param name="paths">
        /// Detect frequent multi-hop connection paths
        /// </param>
        /// <param name="relationships">
        /// Detect common (source_label, edge_type, target_label) relationship triples
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDetectConfig(
            global::Zep.ApidataClusterDetectConfig? clusters,
            global::Zep.ApidataCoOccurrenceDetectConfig? coOccurrences,
            global::Zep.ApidataHubDetectConfig? hubs,
            global::Zep.ApidataPathDetectConfig? paths,
            global::Zep.ApidataRelationshipDetectConfig? relationships)
        {
            this.Clusters = clusters;
            this.CoOccurrences = coOccurrences;
            this.Hubs = hubs;
            this.Paths = paths;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDetectConfig" /> class.
        /// </summary>
        public ApidataDetectConfig()
        {
        }
    }
}