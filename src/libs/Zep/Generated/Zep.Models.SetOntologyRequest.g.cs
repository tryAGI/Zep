
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetOntologyRequest
    {
        /// <summary>
        /// Dictionary mapping entity type names to their definitions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEntities? Entities { get; set; }

        /// <summary>
        /// Dictionary mapping edge type names to their definitions with source/target constraints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEdges? Edges { get; set; }

        /// <summary>
        /// Optional list of user IDs to apply ontology to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Optional list of graph IDs to apply ontology to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_ids")]
        public global::System.Collections.Generic.IList<string>? GraphIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetOntologyRequest" /> class.
        /// </summary>
        /// <param name="entities">
        /// Dictionary mapping entity type names to their definitions
        /// </param>
        /// <param name="edges">
        /// Dictionary mapping edge type names to their definitions with source/target constraints
        /// </param>
        /// <param name="userIds">
        /// Optional list of user IDs to apply ontology to
        /// </param>
        /// <param name="graphIds">
        /// Optional list of graph IDs to apply ontology to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetOntologyRequest(
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEntities? entities,
            global::Zep.GraphSetOntologyPutRequestBodyContentApplicationJsonSchemaEdges? edges,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? graphIds)
        {
            this.Entities = entities;
            this.Edges = edges;
            this.UserIds = userIds;
            this.GraphIds = graphIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetOntologyRequest" /> class.
        /// </summary>
        public SetOntologyRequest()
        {
        }
    }
}