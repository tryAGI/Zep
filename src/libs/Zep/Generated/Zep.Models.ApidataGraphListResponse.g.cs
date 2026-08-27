
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataGraphListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graphs")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataGraph>? Graphs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphListResponse" /> class.
        /// </summary>
        /// <param name="graphs"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="rowCount"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphListResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataGraph>? graphs,
            int? pageNumber,
            int? pageSize,
            int? rowCount,
            int? totalCount)
        {
            this.Graphs = graphs;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.RowCount = rowCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphListResponse" /> class.
        /// </summary>
        public ApidataGraphListResponse()
        {
        }

    }
}