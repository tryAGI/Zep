
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataThreadContextResponse
    {
        /// <summary>
        /// Context block containing relevant facts, entities, and messages/episodes from the user graph. Meant to be replaced in the system prompt on every chat turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadContextResponse" /> class.
        /// </summary>
        /// <param name="context">
        /// Context block containing relevant facts, entities, and messages/episodes from the user graph. Meant to be replaced in the system prompt on every chat turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadContextResponse(
            string? context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadContextResponse" /> class.
        /// </summary>
        public ApidataThreadContextResponse()
        {
        }

    }
}