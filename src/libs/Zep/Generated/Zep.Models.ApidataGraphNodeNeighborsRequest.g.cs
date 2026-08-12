
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphNodeNeighborsRequest
    {
        /// <summary>
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Orientation of the connecting edge relative to the anchor node: "out"<br/>
        /// (anchor is the edge's source), "in" (anchor is the edge's target), or<br/>
        /// "both" (either). Defaults to "both".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }

        /// <summary>
        /// Sort direction for order_by. One of "asc" or "desc". Defaults to<br/>
        /// "desc". Named direction_sort to avoid clashing with the traversal<br/>
        /// Direction field above.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction_sort")]
        public string? DirectionSort { get; set; }

        /// <summary>
        /// Filters constraining the connecting edges (edge types, dates, and the<br/>
        /// section-3 node-/episode-anchored fields) and the neighbor nodes<br/>
        /// (node_labels/exclude_node_labels). Reuses the graph.search filter<br/>
        /// type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::Zep.GraphitiSearchFilters? Filters { get; set; }

        /// <summary>
        /// Maximum number of neighbor nodes to return. An explicit value is<br/>
        /// clamped to 50; when omitted, the default page size (100) applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Field to sort neighbor nodes by. One of "uuid" or "created_at".<br/>
        /// Defaults to "uuid".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphNodeNeighborsRequest" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </param>
        /// <param name="direction">
        /// Orientation of the connecting edge relative to the anchor node: "out"<br/>
        /// (anchor is the edge's source), "in" (anchor is the edge's target), or<br/>
        /// "both" (either). Defaults to "both".
        /// </param>
        /// <param name="directionSort">
        /// Sort direction for order_by. One of "asc" or "desc". Defaults to<br/>
        /// "desc". Named direction_sort to avoid clashing with the traversal<br/>
        /// Direction field above.
        /// </param>
        /// <param name="filters">
        /// Filters constraining the connecting edges (edge types, dates, and the<br/>
        /// section-3 node-/episode-anchored fields) and the neighbor nodes<br/>
        /// (node_labels/exclude_node_labels). Reuses the graph.search filter<br/>
        /// type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of neighbor nodes to return. An explicit value is<br/>
        /// clamped to 50; when omitted, the default page size (100) applies.
        /// </param>
        /// <param name="orderBy">
        /// Field to sort neighbor nodes by. One of "uuid" or "created_at".<br/>
        /// Defaults to "uuid".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphNodeNeighborsRequest(
            string? cursor,
            string? direction,
            string? directionSort,
            global::Zep.GraphitiSearchFilters? filters,
            int? limit,
            string? orderBy)
        {
            this.Cursor = cursor;
            this.Direction = direction;
            this.DirectionSort = directionSort;
            this.Filters = filters;
            this.Limit = limit;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphNodeNeighborsRequest" /> class.
        /// </summary>
        public ApidataGraphNodeNeighborsRequest()
        {
        }

    }
}