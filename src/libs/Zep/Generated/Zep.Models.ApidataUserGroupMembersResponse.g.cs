
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUserGroupMembersResponse
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataUser>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupMembersResponse" /> class.
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="totalCount"></param>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserGroupMembersResponse(
            int? rowCount,
            int? totalCount,
            global::System.Collections.Generic.IList<global::Zep.ApidataUser>? users)
        {
            this.RowCount = rowCount;
            this.TotalCount = totalCount;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupMembersResponse" /> class.
        /// </summary>
        public ApidataUserGroupMembersResponse()
        {
        }

    }
}