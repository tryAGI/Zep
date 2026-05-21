
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiDerivedNode
    {
        /// <summary>
        /// Additional attributes of the derived node.
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
        /// EndAt is the close timestamp of the evidence window. Set when the<br/>
        /// underlying pattern is no longer supported (closed observations);<br/>
        /// nil for active observations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public string? EndAt { get; set; }

        /// <summary>
        /// Episode UUIDs that support this observation. Only populated for observation nodes in web API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episode_ids")]
        public global::System.Collections.Generic.IList<string>? EpisodeIds { get; set; }

        /// <summary>
        /// Labels associated with the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// LatestEvidenceAt is the most recent source-episode timestamp from<br/>
        /// which this observation drew evidence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_evidence_at")]
        public string? LatestEvidenceAt { get; set; }

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
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_rank")]
        public int? SelectionRank { get; set; }

        /// <summary>
        /// StartAt is the earliest source-episode timestamp from which this<br/>
        /// observation was derived. Only populated for observation nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        public string? StartAt { get; set; }

        /// <summary>
        /// Region summary of member nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

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
        /// Initializes a new instance of the <see cref="GraphitiDerivedNode" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation time of the node
        /// </param>
        /// <param name="name">
        /// Name of the node
        /// </param>
        /// <param name="uuid">
        /// UUID of the node
        /// </param>
        /// <param name="attributes">
        /// Additional attributes of the derived node.
        /// </param>
        /// <param name="endAt">
        /// EndAt is the close timestamp of the evidence window. Set when the<br/>
        /// underlying pattern is no longer supported (closed observations);<br/>
        /// nil for active observations.
        /// </param>
        /// <param name="episodeIds">
        /// Episode UUIDs that support this observation. Only populated for observation nodes in web API responses.
        /// </param>
        /// <param name="labels">
        /// Labels associated with the node
        /// </param>
        /// <param name="latestEvidenceAt">
        /// LatestEvidenceAt is the most recent source-episode timestamp from<br/>
        /// which this observation drew evidence.
        /// </param>
        /// <param name="relevance">
        /// Relevance is an experimental rank-aligned score in [0,1] derived from Score via logit transformation.<br/>
        /// Only populated when using cross_encoder reranker; omitted for other reranker types (e.g., RRF).
        /// </param>
        /// <param name="score">
        /// Score is the reranker output: sigmoid-distributed logits [0,1] when using cross_encoder reranker, or RRF ordinal rank when using rrf reranker
        /// </param>
        /// <param name="selectionRank">
        /// SelectionRank is the global cross-scope rank assigned by auto scope selection.
        /// </param>
        /// <param name="startAt">
        /// StartAt is the earliest source-episode timestamp from which this<br/>
        /// observation was derived. Only populated for observation nodes.
        /// </param>
        /// <param name="summary">
        /// Region summary of member nodes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiDerivedNode(
            string createdAt,
            string name,
            string uuid,
            object? attributes,
            string? endAt,
            global::System.Collections.Generic.IList<string>? episodeIds,
            global::System.Collections.Generic.IList<string>? labels,
            string? latestEvidenceAt,
            double? relevance,
            double? score,
            int? selectionRank,
            string? startAt,
            string? summary)
        {
            this.Attributes = attributes;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.EndAt = endAt;
            this.EpisodeIds = episodeIds;
            this.Labels = labels;
            this.LatestEvidenceAt = latestEvidenceAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Relevance = relevance;
            this.Score = score;
            this.SelectionRank = selectionRank;
            this.StartAt = startAt;
            this.Summary = summary;
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiDerivedNode" /> class.
        /// </summary>
        public GraphitiDerivedNode()
        {
        }

    }
}