
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiSearchFilters
    {
        /// <summary>
        /// 2D array of date filters for the created_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(created_at &gt; date1 AND created_at &lt; date2) OR (created_at = date3)`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? CreatedAt { get; set; }

        /// <summary>
        /// List of edge types to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_types")]
        public global::System.Collections.Generic.IList<string>? EdgeTypes { get; set; }

        /// <summary>
        /// List of edge UUIDs to filter on. Max 256 to align with graph-service filter limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_uuids")]
        public global::System.Collections.Generic.IList<string>? EdgeUuids { get; set; }

        /// <summary>
        /// [Experimental] Episode metadata filter. Restricts results to edges/nodes derived from episodes<br/>
        /// matching the metadata predicates. Uses explicit AND/OR groups. This feature is experimental and may change in future releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episode_metadata_filters")]
        public global::Zep.GraphitiMetadataFilterGroup? EpisodeMetadataFilters { get; set; }

        /// <summary>
        /// List of edge types to exclude from results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_edge_types")]
        public global::System.Collections.Generic.IList<string>? ExcludeEdgeTypes { get; set; }

        /// <summary>
        /// List of node labels to exclude from results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_node_labels")]
        public global::System.Collections.Generic.IList<string>? ExcludeNodeLabels { get; set; }

        /// <summary>
        /// 2D array of date filters for the expired_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(expired_at &gt; date1 AND expired_at &lt; date2) OR (expired_at = date3)`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? ExpiredAt { get; set; }

        /// <summary>
        /// 2D array of date filters for the invalid_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(invalid_at &gt; date1 AND invalid_at &lt; date2) OR (invalid_at = date3)`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_at")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? InvalidAt { get; set; }

        /// <summary>
        /// List of node labels to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_labels")]
        public global::System.Collections.Generic.IList<string>? NodeLabels { get; set; }

        /// <summary>
        /// List of property filters to apply to nodes and edges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_filters")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiPropertyFilter>? PropertyFilters { get; set; }

        /// <summary>
        /// 2D array of date filters for the valid_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(valid_at &gt; date1 AND valid_at &lt; date2) OR (valid_at = date3)`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? ValidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiSearchFilters" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// 2D array of date filters for the created_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(created_at &gt; date1 AND created_at &lt; date2) OR (created_at = date3)`
        /// </param>
        /// <param name="edgeTypes">
        /// List of edge types to filter on
        /// </param>
        /// <param name="edgeUuids">
        /// List of edge UUIDs to filter on. Max 256 to align with graph-service filter limits.
        /// </param>
        /// <param name="episodeMetadataFilters">
        /// [Experimental] Episode metadata filter. Restricts results to edges/nodes derived from episodes<br/>
        /// matching the metadata predicates. Uses explicit AND/OR groups. This feature is experimental and may change in future releases.
        /// </param>
        /// <param name="excludeEdgeTypes">
        /// List of edge types to exclude from results
        /// </param>
        /// <param name="excludeNodeLabels">
        /// List of node labels to exclude from results
        /// </param>
        /// <param name="expiredAt">
        /// 2D array of date filters for the expired_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(expired_at &gt; date1 AND expired_at &lt; date2) OR (expired_at = date3)`
        /// </param>
        /// <param name="invalidAt">
        /// 2D array of date filters for the invalid_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(invalid_at &gt; date1 AND invalid_at &lt; date2) OR (invalid_at = date3)`
        /// </param>
        /// <param name="nodeLabels">
        /// List of node labels to filter on
        /// </param>
        /// <param name="propertyFilters">
        /// List of property filters to apply to nodes and edges
        /// </param>
        /// <param name="validAt">
        /// 2D array of date filters for the valid_at field.<br/>
        /// The outer array elements are combined with OR logic.<br/>
        /// The inner array elements are combined with AND logic.<br/>
        /// Example: `[[{"&gt;", date1}, {"&lt;", date2}], [{"=", date3}]]`<br/>
        /// This translates to: `(valid_at &gt; date1 AND valid_at &lt; date2) OR (valid_at = date3)`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiSearchFilters(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? createdAt,
            global::System.Collections.Generic.IList<string>? edgeTypes,
            global::System.Collections.Generic.IList<string>? edgeUuids,
            global::Zep.GraphitiMetadataFilterGroup? episodeMetadataFilters,
            global::System.Collections.Generic.IList<string>? excludeEdgeTypes,
            global::System.Collections.Generic.IList<string>? excludeNodeLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? expiredAt,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? invalidAt,
            global::System.Collections.Generic.IList<string>? nodeLabels,
            global::System.Collections.Generic.IList<global::Zep.GraphitiPropertyFilter>? propertyFilters,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Zep.GraphitiDateFilter>>? validAt)
        {
            this.CreatedAt = createdAt;
            this.EdgeTypes = edgeTypes;
            this.EdgeUuids = edgeUuids;
            this.EpisodeMetadataFilters = episodeMetadataFilters;
            this.ExcludeEdgeTypes = excludeEdgeTypes;
            this.ExcludeNodeLabels = excludeNodeLabels;
            this.ExpiredAt = expiredAt;
            this.InvalidAt = invalidAt;
            this.NodeLabels = nodeLabels;
            this.PropertyFilters = propertyFilters;
            this.ValidAt = validAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiSearchFilters" /> class.
        /// </summary>
        public GraphitiSearchFilters()
        {
        }

    }
}