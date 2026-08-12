
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphEpisodeListRequest
    {
        /// <summary>
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Sort direction. One of "asc" or "desc". Defaults to "desc".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public string? Direction { get; set; }

        /// <summary>
        /// Maximum number of episodes to return. An explicit value is clamped to<br/>
        /// 50; when omitted, the default page size (100) applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Restricts results to episodes that mention any of the listed node<br/>
        /// UUIDs. At most 256 entries; each must be a syntactically valid UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentioned_node_uuids")]
        public global::System.Collections.Generic.IList<string>? MentionedNodeUuids { get; set; }

        /// <summary>
        /// Field to sort by. One of "uuid" or "created_at". Defaults to "uuid".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisodeListRequest" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor for pagination, obtained from the Zep-Next-Cursor<br/>
        /// response header of the previous page.
        /// </param>
        /// <param name="direction">
        /// Sort direction. One of "asc" or "desc". Defaults to "desc".
        /// </param>
        /// <param name="limit">
        /// Maximum number of episodes to return. An explicit value is clamped to<br/>
        /// 50; when omitted, the default page size (100) applies.
        /// </param>
        /// <param name="mentionedNodeUuids">
        /// Restricts results to episodes that mention any of the listed node<br/>
        /// UUIDs. At most 256 entries; each must be a syntactically valid UUID.
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by. One of "uuid" or "created_at". Defaults to "uuid".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphEpisodeListRequest(
            string? cursor,
            string? direction,
            int? limit,
            global::System.Collections.Generic.IList<string>? mentionedNodeUuids,
            string? orderBy)
        {
            this.Cursor = cursor;
            this.Direction = direction;
            this.Limit = limit;
            this.MentionedNodeUuids = mentionedNodeUuids;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisodeListRequest" /> class.
        /// </summary>
        public ApidataGraphEpisodeListRequest()
        {
        }

    }
}