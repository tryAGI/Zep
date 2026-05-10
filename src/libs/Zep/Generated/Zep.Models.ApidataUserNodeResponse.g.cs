
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUserNodeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public global::Zep.GraphitiEntityNode? Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserNodeResponse" /> class.
        /// </summary>
        /// <param name="node"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserNodeResponse(
            global::Zep.GraphitiEntityNode? node)
        {
            this.Node = node;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserNodeResponse" /> class.
        /// </summary>
        public ApidataUserNodeResponse()
        {
        }

    }
}