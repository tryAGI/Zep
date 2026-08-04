
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataAttachedPolicySetsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_sets")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataPolicySetSummaryResponse>? PolicySets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAttachedPolicySetsResponse" /> class.
        /// </summary>
        /// <param name="policySets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAttachedPolicySetsResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataPolicySetSummaryResponse>? policySets)
        {
            this.PolicySets = policySets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAttachedPolicySetsResponse" /> class.
        /// </summary>
        public ApidataAttachedPolicySetsResponse()
        {
        }

    }
}