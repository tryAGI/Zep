
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataEntityTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_types")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataEdgeType>? EdgeTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_types")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataEntityType>? EntityTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEntityTypeResponse" /> class.
        /// </summary>
        /// <param name="edgeTypes"></param>
        /// <param name="entityTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataEntityTypeResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataEdgeType>? edgeTypes,
            global::System.Collections.Generic.IList<global::Zep.ApidataEntityType>? entityTypes)
        {
            this.EdgeTypes = edgeTypes;
            this.EntityTypes = entityTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataEntityTypeResponse" /> class.
        /// </summary>
        public ApidataEntityTypeResponse()
        {
        }

    }
}