
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphThreadSummariesRequest
    {
        /// <summary>
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor response header<br/>
        /// of the previous page. Encodes the sort field, direction, and continuation position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Sort direction. One of "asc" or "desc" (default "desc").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }

        /// <summary>
        /// Optional filters applied to the listed artifacts. Reuses the graph.search filter type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::Zep.GraphitiSearchFilters? Filters { get; set; }

        /// <summary>
        /// Maximum number of items to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Field to sort by. One of "created_at" or "uuid" (default "uuid").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page.<br/>
        /// Deprecated: prefer Cursor, the opaque cursor returned via the Zep-Next-Cursor response header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid_cursor")]
        public string? UuidCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphThreadSummariesRequest" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor response header<br/>
        /// of the previous page. Encodes the sort field, direction, and continuation position.
        /// </param>
        /// <param name="direction">
        /// Sort direction. One of "asc" or "desc" (default "desc").
        /// </param>
        /// <param name="filters">
        /// Optional filters applied to the listed artifacts. Reuses the graph.search filter type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by. One of "created_at" or "uuid" (default "uuid").
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page.<br/>
        /// Deprecated: prefer Cursor, the opaque cursor returned via the Zep-Next-Cursor response header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphThreadSummariesRequest(
            string? cursor,
            string? direction,
            global::Zep.GraphitiSearchFilters? filters,
            int? limit,
            string? orderBy,
            string? uuidCursor)
        {
            this.Cursor = cursor;
            this.Direction = direction;
            this.Filters = filters;
            this.Limit = limit;
            this.OrderBy = orderBy;
            this.UuidCursor = uuidCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphThreadSummariesRequest" /> class.
        /// </summary>
        public ApidataGraphThreadSummariesRequest()
        {
        }

    }
}