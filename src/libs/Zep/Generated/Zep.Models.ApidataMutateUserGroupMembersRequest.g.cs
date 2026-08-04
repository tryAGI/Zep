
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataMutateUserGroupMembersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_uuids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserUuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataMutateUserGroupMembersRequest" /> class.
        /// </summary>
        /// <param name="userUuids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataMutateUserGroupMembersRequest(
            global::System.Collections.Generic.IList<string> userUuids)
        {
            this.UserUuids = userUuids ?? throw new global::System.ArgumentNullException(nameof(userUuids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataMutateUserGroupMembersRequest" /> class.
        /// </summary>
        public ApidataMutateUserGroupMembersRequest()
        {
        }

    }
}