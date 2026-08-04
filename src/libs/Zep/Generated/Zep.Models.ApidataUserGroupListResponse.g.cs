
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUserGroupListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        public global::Zep.ModelsUserGroupQuota? Quota { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_groups")]
        public global::System.Collections.Generic.IList<global::Zep.ModelsUserGroup>? UserGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupListResponse" /> class.
        /// </summary>
        /// <param name="quota"></param>
        /// <param name="rowCount"></param>
        /// <param name="totalCount"></param>
        /// <param name="userGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserGroupListResponse(
            global::Zep.ModelsUserGroupQuota? quota,
            int? rowCount,
            int? totalCount,
            global::System.Collections.Generic.IList<global::Zep.ModelsUserGroup>? userGroups)
        {
            this.Quota = quota;
            this.RowCount = rowCount;
            this.TotalCount = totalCount;
            this.UserGroups = userGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupListResponse" /> class.
        /// </summary>
        public ApidataUserGroupListResponse()
        {
        }

    }
}