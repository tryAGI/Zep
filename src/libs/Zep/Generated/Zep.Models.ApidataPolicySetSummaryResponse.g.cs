
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataPolicySetSummaryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPolicySetSummaryResponse" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="name"></param>
        /// <param name="uuid"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataPolicySetSummaryResponse(
            string? mode,
            string? name,
            string? uuid,
            int? version)
        {
            this.Mode = mode;
            this.Name = name;
            this.Uuid = uuid;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPolicySetSummaryResponse" /> class.
        /// </summary>
        public ApidataPolicySetSummaryResponse()
        {
        }

    }
}