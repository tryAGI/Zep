
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataCoOccurrenceDetectConfig
    {
        /// <summary>
        /// Max hops within which to detect co-occurring node types. Default: 3, Max: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_hops")]
        public int? MaxHops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCoOccurrenceDetectConfig" /> class.
        /// </summary>
        /// <param name="maxHops">
        /// Max hops within which to detect co-occurring node types. Default: 3, Max: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCoOccurrenceDetectConfig(
            int? maxHops)
        {
            this.MaxHops = maxHops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCoOccurrenceDetectConfig" /> class.
        /// </summary>
        public ApidataCoOccurrenceDetectConfig()
        {
        }

    }
}