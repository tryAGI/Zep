
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataEntityEdgeSourceTarget
    {
        /// <summary>
        /// Source represents the originating node identifier in the edge type relationship. (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Target represents the target node identifier in the edge type relationship. (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEntityEdgeSourceTarget" /> class.
        /// </summary>
        /// <param name="source">
        /// Source represents the originating node identifier in the edge type relationship. (optional)
        /// </param>
        /// <param name="target">
        /// Target represents the target node identifier in the edge type relationship. (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataEntityEdgeSourceTarget(
            string? source,
            string? target)
        {
            this.Source = source;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEntityEdgeSourceTarget" /> class.
        /// </summary>
        public ApidataEntityEdgeSourceTarget()
        {
        }

    }
}