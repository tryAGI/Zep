
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataAttachPolicySetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_set_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicySetUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAttachPolicySetRequest" /> class.
        /// </summary>
        /// <param name="policySetUuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAttachPolicySetRequest(
            string policySetUuid)
        {
            this.PolicySetUuid = policySetUuid ?? throw new global::System.ArgumentNullException(nameof(policySetUuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAttachPolicySetRequest" /> class.
        /// </summary>
        public ApidataAttachPolicySetRequest()
        {
        }

    }
}