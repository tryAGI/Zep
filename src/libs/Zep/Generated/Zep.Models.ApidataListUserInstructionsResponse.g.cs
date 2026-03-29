
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataListUserInstructionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction>? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataListUserInstructionsResponse" /> class.
        /// </summary>
        /// <param name="instructions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataListUserInstructionsResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction>? instructions)
        {
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataListUserInstructionsResponse" /> class.
        /// </summary>
        public ApidataListUserInstructionsResponse()
        {
        }
    }
}