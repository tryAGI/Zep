
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiEntityEdge
    {
        /// <summary>
        /// Additional attributes of the edge. Dependent on edge types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Creation time of the edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// List of episode ids that reference these entity edges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        public global::System.Collections.Generic.IList<string>? Episodes { get; set; }

        /// <summary>
        /// Datetime of when the node was invalidated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public string? ExpiredAt { get; set; }

        /// <summary>
        /// Fact representing the edge and nodes that it connects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fact { get; set; }

        /// <summary>
        /// Datetime of when the fact stopped being true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_at")]
        public string? InvalidAt { get; set; }

        /// <summary>
        /// Name of the edge, relation name
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
        /// Scope of the edge (e.g. "entity", "maybe_related")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_rank")]
        public int? SelectionRank { get; set; }

        /// <summary>
        /// UUID of the source node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeUuid { get; set; }

        /// <summary>
        /// UUID of the target node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeUuid { get; set; }

        /// <summary>
        /// UUID of the edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Datetime of when the fact became true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        public string? ValidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEntityEdge" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation time of the edge
        /// </param>
        /// <param name="fact">
        /// Fact representing the edge and nodes that it connects
        /// </param>
        /// <param name="name">
        /// Name of the edge, relation name
        /// </param>
        /// <param name="sourceNodeUuid">
        /// UUID of the source node
        /// </param>
        /// <param name="targetNodeUuid">
        /// UUID of the target node
        /// </param>
        /// <param name="uuid">
        /// UUID of the edge
        /// </param>
        /// <param name="attributes">
        /// Additional attributes of the edge. Dependent on edge types
        /// </param>
        /// <param name="episodes">
        /// List of episode ids that reference these entity edges
        /// </param>
        /// <param name="expiredAt">
        /// Datetime of when the node was invalidated
        /// </param>
        /// <param name="invalidAt">
        /// Datetime of when the fact stopped being true
        /// </param>
        /// <param name="relevance">
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </param>
        /// <param name="scope">
        /// Scope of the edge (e.g. "entity", "maybe_related")
        /// </param>
        /// <param name="score">
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </param>
        /// <param name="selectionRank">
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </param>
        /// <param name="validAt">
        /// Datetime of when the fact became true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiEntityEdge(
            string createdAt,
            string fact,
            string name,
            string sourceNodeUuid,
            string targetNodeUuid,
            string uuid,
            object? attributes,
            global::System.Collections.Generic.IList<string>? episodes,
            string? expiredAt,
            string? invalidAt,
            double? relevance,
            string? scope,
            double? score,
            int? selectionRank,
            string? validAt)
        {
            this.Attributes = attributes;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Episodes = episodes;
            this.ExpiredAt = expiredAt;
            this.Fact = fact ?? throw new global::System.ArgumentNullException(nameof(fact));
            this.InvalidAt = invalidAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Relevance = relevance;
            this.Scope = scope;
            this.Score = score;
            this.SelectionRank = selectionRank;
            this.SourceNodeUuid = sourceNodeUuid ?? throw new global::System.ArgumentNullException(nameof(sourceNodeUuid));
            this.TargetNodeUuid = targetNodeUuid ?? throw new global::System.ArgumentNullException(nameof(targetNodeUuid));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.ValidAt = validAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiEntityEdge" /> class.
        /// </summary>
        public GraphitiEntityEdge()
        {
        }

    }
}