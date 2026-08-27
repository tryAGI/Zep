
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataBatchSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_roles")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? IgnoreRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        public string? ProcessedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Zep.ApidataBatchProgress? Progress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsBatchStatusJsonConverter))]
        public global::Zep.ModelsBatchStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_ontology")]
        public bool? StrictOntology { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchSummary" /> class.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="ignoreRoles"></param>
        /// <param name="itemCount"></param>
        /// <param name="metadata"></param>
        /// <param name="processedAt"></param>
        /// <param name="progress"></param>
        /// <param name="status"></param>
        /// <param name="strictOntology"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchSummary(
            string? batchId,
            string? completedAt,
            string? createdAt,
            global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? ignoreRoles,
            int? itemCount,
            object? metadata,
            string? processedAt,
            global::Zep.ApidataBatchProgress? progress,
            global::Zep.ModelsBatchStatus? status,
            bool? strictOntology,
            string? updatedAt)
        {
            this.BatchId = batchId;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.IgnoreRoles = ignoreRoles;
            this.ItemCount = itemCount;
            this.Metadata = metadata;
            this.ProcessedAt = processedAt;
            this.Progress = progress;
            this.Status = status;
            this.StrictOntology = strictOntology;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchSummary" /> class.
        /// </summary>
        public ApidataBatchSummary()
        {
        }

    }
}