
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataUserMembershipGroupsResponse
    {
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
        /// Initializes a new instance of the <see cref="ApidataUserMembershipGroupsResponse" /> class.
        /// </summary>
        /// <param name="userGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserMembershipGroupsResponse(
            global::System.Collections.Generic.IList<global::Zep.ModelsUserGroup>? userGroups)
        {
            this.UserGroups = userGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserMembershipGroupsResponse" /> class.
        /// </summary>
        public ApidataUserMembershipGroupsResponse()
        {
        }

    }
}