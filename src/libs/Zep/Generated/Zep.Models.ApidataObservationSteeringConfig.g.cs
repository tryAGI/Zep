
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataObservationSteeringConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataObservationType>? Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataObservationSteeringConfig" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="types"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataObservationSteeringConfig(
            string? instruction,
            global::System.Collections.Generic.IList<global::Zep.ApidataObservationType>? types)
        {
            this.Instruction = instruction;
            this.Types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataObservationSteeringConfig" /> class.
        /// </summary>
        public ApidataObservationSteeringConfig()
        {
        }

    }
}