
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataTaskProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        public string? Stage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataTaskProgress" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="stage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataTaskProgress(
            string? message,
            string? stage)
        {
            this.Message = message;
            this.Stage = stage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataTaskProgress" /> class.
        /// </summary>
        public ApidataTaskProgress()
        {
        }

    }
}