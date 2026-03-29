
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiEntityNode
    {
        /// <summary>
        /// Additional attributes of the node. Dependent on node labels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Creation time of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Labels associated with the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Name of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance")]
        public double? Relevance { get; set; }

        /// <summary>
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Regional summary of surrounding edges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// UUID of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEntityNode" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation time of the node
        /// </param>
        /// <param name="name">
        /// Name of the node
        /// </param>
        /// <param name="summary">
        /// Regional summary of surrounding edges
        /// </param>
        /// <param name="uuid">
        /// UUID of the node
        /// </param>
        /// <param name="attributes">
        /// Additional attributes of the node. Dependent on node labels
        /// </param>
        /// <param name="labels">
        /// Labels associated with the node
        /// </param>
        /// <param name="relevance">
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </param>
        /// <param name="score">
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiEntityNode(
            string createdAt,
            string name,
            string summary,
            string uuid,
            object? attributes,
            global::System.Collections.Generic.IList<string>? labels,
            double? relevance,
            double? score)
        {
            this.Attributes = attributes;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Labels = labels;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Relevance = relevance;
            this.Score = score;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEntityNode" /> class.
        /// </summary>
        public GraphitiEntityNode()
        {
        }
    }
}