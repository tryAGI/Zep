
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphSearchResponseMetadata
    {
        /// <summary>
        /// Server-side processing latency in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_latency_ms")]
        public int? ServerLatencyMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResponseMetadata" /> class.
        /// </summary>
        /// <param name="serverLatencyMs">
        /// Server-side processing latency in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphSearchResponseMetadata(
            int? serverLatencyMs)
        {
            this.ServerLatencyMs = serverLatencyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphSearchResponseMetadata" /> class.
        /// </summary>
        public ApidataGraphSearchResponseMetadata()
        {
        }

    }
}