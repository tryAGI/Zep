
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataDeleteUserInstructionsRequest
    {
        /// <summary>
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction_names")]
        public global::System.Collections.Generic.IList<string>? InstructionNames { get; set; }

        /// <summary>
        /// Determines which users will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be effected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDeleteUserInstructionsRequest" /> class.
        /// </summary>
        /// <param name="instructionNames">
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </param>
        /// <param name="userIds">
        /// Determines which users will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be effected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDeleteUserInstructionsRequest(
            global::System.Collections.Generic.IList<string>? instructionNames,
            global::System.Collections.Generic.IList<string>? userIds)
        {
            this.InstructionNames = instructionNames;
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDeleteUserInstructionsRequest" /> class.
        /// </summary>
        public ApidataDeleteUserInstructionsRequest()
        {
        }

    }
}