
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataAddUserInstructionsRequest
    {
        /// <summary>
        /// Instructions to add to the user summary generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction> Instructions { get; set; }

        /// <summary>
        /// User IDs to add the instructions to. If empty, the instructions are added to the project-wide default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddUserInstructionsRequest" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions to add to the user summary generation.
        /// </param>
        /// <param name="userIds">
        /// User IDs to add the instructions to. If empty, the instructions are added to the project-wide default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAddUserInstructionsRequest(
            global::System.Collections.Generic.IList<global::Zep.ApidataUserInstruction> instructions,
            global::System.Collections.Generic.IList<string>? userIds)
        {
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddUserInstructionsRequest" /> class.
        /// </summary>
        public ApidataAddUserInstructionsRequest()
        {
        }

    }
}