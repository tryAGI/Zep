
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataPathDetectConfig
    {
        /// <summary>
        /// Max hops from seed nodes for path detection. Default: 3, Max: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_hops")]
        public int? MaxHops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPathDetectConfig" /> class.
        /// </summary>
        /// <param name="maxHops">
        /// Max hops from seed nodes for path detection. Default: 3, Max: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataPathDetectConfig(
            int? maxHops)
        {
            this.MaxHops = maxHops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataPathDetectConfig" /> class.
        /// </summary>
        public ApidataPathDetectConfig()
        {
        }
    }
}