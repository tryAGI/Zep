
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphEdgesRequest
    {
        /// <summary>
        /// Maximum number of items to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid_cursor")]
        public string? UuidCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEdgesRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return
        /// </param>
        /// <param name="uuidCursor">
        /// UUID based cursor, used for pagination. Should be the UUID of the last item in the previous page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphEdgesRequest(
            int? limit,
            string? uuidCursor)
        {
            this.Limit = limit;
            this.UuidCursor = uuidCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEdgesRequest" /> class.
        /// </summary>
        public ApidataGraphEdgesRequest()
        {
        }
    }
}