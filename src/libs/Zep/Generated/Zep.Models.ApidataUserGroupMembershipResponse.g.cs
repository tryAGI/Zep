
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUserGroupMembershipResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_count")]
        public int? AddedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_op_count")]
        public int? NoOpCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_count")]
        public int? RemovedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupMembershipResponse" /> class.
        /// </summary>
        /// <param name="addedCount"></param>
        /// <param name="noOpCount"></param>
        /// <param name="removedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserGroupMembershipResponse(
            int? addedCount,
            int? noOpCount,
            int? removedCount)
        {
            this.AddedCount = addedCount;
            this.NoOpCount = noOpCount;
            this.RemovedCount = removedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupMembershipResponse" /> class.
        /// </summary>
        public ApidataUserGroupMembershipResponse()
        {
        }

    }
}