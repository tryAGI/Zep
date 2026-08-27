
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataHubDetectConfig
    {
        /// <summary>
        /// Minimum number of connections for a node to be considered a hub. Default: 3, Min: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_degree")]
        public int? MinDegree { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataHubDetectConfig" /> class.
        /// </summary>
        /// <param name="minDegree">
        /// Minimum number of connections for a node to be considered a hub. Default: 3, Min: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataHubDetectConfig(
            int? minDegree)
        {
            this.MinDegree = minDegree;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataHubDetectConfig" /> class.
        /// </summary>
        public ApidataHubDetectConfig()
        {
        }

    }
}