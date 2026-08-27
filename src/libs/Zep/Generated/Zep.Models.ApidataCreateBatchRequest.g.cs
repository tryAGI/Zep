
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataCreateBatchRequest
    {
        /// <summary>
        /// Optional list of message role types to skip during graph ingestion for<br/>
        /// thread_message items in this batch. The messages are still stored and<br/>
        /// retained as context, but no graph extraction is performed for them.<br/>
        /// Has no effect on graph_episode items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_roles")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? IgnoreRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_ontology")]
        public bool? StrictOntology { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateBatchRequest" /> class.
        /// </summary>
        /// <param name="ignoreRoles">
        /// Optional list of message role types to skip during graph ingestion for<br/>
        /// thread_message items in this batch. The messages are still stored and<br/>
        /// retained as context, but no graph extraction is performed for them.<br/>
        /// Has no effect on graph_episode items.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="strictOntology">
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCreateBatchRequest(
            global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? ignoreRoles,
            object? metadata,
            bool? strictOntology)
        {
            this.IgnoreRoles = ignoreRoles;
            this.Metadata = metadata;
            this.StrictOntology = strictOntology;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateBatchRequest" /> class.
        /// </summary>
        public ApidataCreateBatchRequest()
        {
        }

    }
}