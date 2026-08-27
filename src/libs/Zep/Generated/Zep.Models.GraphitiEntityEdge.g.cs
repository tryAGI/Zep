
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
        /// SourceNodeLabels are the labels of the source node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_labels")]
        public global::System.Collections.Generic.IList<string>? SourceNodeLabels { get; set; }

        /// <summary>
        /// SourceNodeName is the name of the source node at read time. It is a<br/>
        /// read-time projection of current node state, not a stored edge<br/>
        /// attribute: a subsequent node rename is reflected on the next read.<br/>
        /// Omitted (the edge is still returned) if the source node cannot be<br/>
        /// resolved, for example if it was deleted concurrently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_name")]
        public string? SourceNodeName { get; set; }

        /// <summary>
        /// UUID of the source node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeUuid { get; set; }

        /// <summary>
        /// TargetNodeLabels are the labels of the target node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_labels")]
        public global::System.Collections.Generic.IList<string>? TargetNodeLabels { get; set; }

        /// <summary>
        /// TargetNodeName is the name of the target node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_name")]
        public string? TargetNodeName { get; set; }

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
        /// <param name="sourceNodeLabels">
        /// SourceNodeLabels are the labels of the source node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
        /// </param>
        /// <param name="sourceNodeName">
        /// SourceNodeName is the name of the source node at read time. It is a<br/>
        /// read-time projection of current node state, not a stored edge<br/>
        /// attribute: a subsequent node rename is reflected on the next read.<br/>
        /// Omitted (the edge is still returned) if the source node cannot be<br/>
        /// resolved, for example if it was deleted concurrently.
        /// </param>
        /// <param name="targetNodeLabels">
        /// TargetNodeLabels are the labels of the target node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
        /// </param>
        /// <param name="targetNodeName">
        /// TargetNodeName is the name of the target node at read time. Same<br/>
        /// read-time-projection semantics as SourceNodeName.
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
            global::System.Collections.Generic.IList<string>? sourceNodeLabels,
            string? sourceNodeName,
            global::System.Collections.Generic.IList<string>? targetNodeLabels,
            string? targetNodeName,
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
            this.SourceNodeLabels = sourceNodeLabels;
            this.SourceNodeName = sourceNodeName;
            this.SourceNodeUuid = sourceNodeUuid ?? throw new global::System.ArgumentNullException(nameof(sourceNodeUuid));
            this.TargetNodeLabels = targetNodeLabels;
            this.TargetNodeName = targetNodeName;
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