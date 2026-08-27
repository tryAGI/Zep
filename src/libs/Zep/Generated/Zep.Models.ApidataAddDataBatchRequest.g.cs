
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataAddDataBatchRequest
    {
        /// <summary>
        /// Optional document ID applied to every episode in this batch request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zep.ApidataEpisodeData> Episodes { get; set; }

        /// <summary>
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_ontology")]
        public bool? StrictOntology { get; set; }

        /// <summary>
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddDataBatchRequest" /> class.
        /// </summary>
        /// <param name="episodes"></param>
        /// <param name="documentId">
        /// Optional document ID applied to every episode in this batch request.
        /// </param>
        /// <param name="graphId">
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </param>
        /// <param name="strictOntology">
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </param>
        /// <param name="userId">
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAddDataBatchRequest(
            global::System.Collections.Generic.IList<global::Zep.ApidataEpisodeData> episodes,
            string? documentId,
            string? graphId,
            bool? strictOntology,
            string? userId)
        {
            this.DocumentId = documentId;
            this.Episodes = episodes ?? throw new global::System.ArgumentNullException(nameof(episodes));
            this.GraphId = graphId;
            this.StrictOntology = strictOntology;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddDataBatchRequest" /> class.
        /// </summary>
        public ApidataAddDataBatchRequest()
        {
        }

    }
}