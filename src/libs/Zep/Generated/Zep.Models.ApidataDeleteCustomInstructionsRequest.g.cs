
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataDeleteCustomInstructionsRequest
    {
        /// <summary>
        /// Determines which group graphs will have their custom instructions deleted. If no graphs are provided, the project-wide custom instructions will be affected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_ids")]
        public global::System.Collections.Generic.IList<string>? GraphIds { get; set; }

        /// <summary>
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction_names")]
        public global::System.Collections.Generic.IList<string>? InstructionNames { get; set; }

        /// <summary>
        /// Determines which user graphs will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be affected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDeleteCustomInstructionsRequest" /> class.
        /// </summary>
        /// <param name="graphIds">
        /// Determines which group graphs will have their custom instructions deleted. If no graphs are provided, the project-wide custom instructions will be affected.
        /// </param>
        /// <param name="instructionNames">
        /// Unique identifier for the instructions to be deleted. If empty deletes all instructions.
        /// </param>
        /// <param name="userIds">
        /// Determines which user graphs will have their custom instructions deleted. If no users are provided, the project-wide custom instructions will be affected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataDeleteCustomInstructionsRequest(
            global::System.Collections.Generic.IList<string>? graphIds,
            global::System.Collections.Generic.IList<string>? instructionNames,
            global::System.Collections.Generic.IList<string>? userIds)
        {
            this.GraphIds = graphIds;
            this.InstructionNames = instructionNames;
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataDeleteCustomInstructionsRequest" /> class.
        /// </summary>
        public ApidataDeleteCustomInstructionsRequest()
        {
        }

    }
}