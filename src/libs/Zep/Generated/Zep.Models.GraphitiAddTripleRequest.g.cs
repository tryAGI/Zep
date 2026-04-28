
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiAddTripleRequest
    {
        /// <summary>
        /// The timestamp of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional attributes of the edge. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_attributes")]
        public object? EdgeAttributes { get; set; }

        /// <summary>
        /// The time (if any) at which the edge expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public string? ExpiredAt { get; set; }

        /// <summary>
        /// The fact relating the two nodes that this edge represents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fact { get; set; }

        /// <summary>
        /// The name of the edge to add. Should be all caps using snake case (eg RELATES_TO)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FactName { get; set; }

        /// <summary>
        /// The uuid of the edge to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact_uuid")]
        public string? FactUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// The time (if any) at which the fact stops being true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_at")]
        public string? InvalidAt { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs for the shadow episode created for this fact triple.<br/>
        /// Max 10 keys. Values must be strings, numbers, or booleans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional attributes of the source node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_attributes")]
        public object? SourceNodeAttributes { get; set; }

        /// <summary>
        /// The labels for the source node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_labels")]
        public global::System.Collections.Generic.IList<string>? SourceNodeLabels { get; set; }

        /// <summary>
        /// The name of the source node to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_name")]
        public string? SourceNodeName { get; set; }

        /// <summary>
        /// The summary of the source node to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_summary")]
        public string? SourceNodeSummary { get; set; }

        /// <summary>
        /// The source node uuid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_uuid")]
        public string? SourceNodeUuid { get; set; }

        /// <summary>
        /// Additional attributes of the target node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_attributes")]
        public object? TargetNodeAttributes { get; set; }

        /// <summary>
        /// The labels for the target node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_labels")]
        public global::System.Collections.Generic.IList<string>? TargetNodeLabels { get; set; }

        /// <summary>
        /// The name of the target node to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_name")]
        public string? TargetNodeName { get; set; }

        /// <summary>
        /// The summary of the target node to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_summary")]
        public string? TargetNodeSummary { get; set; }

        /// <summary>
        /// The target node uuid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_uuid")]
        public string? TargetNodeUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The time at which the fact becomes true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        public string? ValidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddTripleRequest" /> class.
        /// </summary>
        /// <param name="fact">
        /// The fact relating the two nodes that this edge represents
        /// </param>
        /// <param name="factName">
        /// The name of the edge to add. Should be all caps using snake case (eg RELATES_TO)
        /// </param>
        /// <param name="createdAt">
        /// The timestamp of the message
        /// </param>
        /// <param name="edgeAttributes">
        /// Additional attributes of the edge. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="expiredAt">
        /// The time (if any) at which the edge expires
        /// </param>
        /// <param name="factUuid">
        /// The uuid of the edge to add
        /// </param>
        /// <param name="graphId"></param>
        /// <param name="invalidAt">
        /// The time (if any) at which the fact stops being true
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs for the shadow episode created for this fact triple.<br/>
        /// Max 10 keys. Values must be strings, numbers, or booleans.
        /// </param>
        /// <param name="sourceNodeAttributes">
        /// Additional attributes of the source node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="sourceNodeLabels">
        /// The labels for the source node
        /// </param>
        /// <param name="sourceNodeName">
        /// The name of the source node to add
        /// </param>
        /// <param name="sourceNodeSummary">
        /// The summary of the source node to add
        /// </param>
        /// <param name="sourceNodeUuid">
        /// The source node uuid
        /// </param>
        /// <param name="targetNodeAttributes">
        /// Additional attributes of the target node. Values must be scalar types (string, number, boolean, or null).<br/>
        /// Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="targetNodeLabels">
        /// The labels for the target node
        /// </param>
        /// <param name="targetNodeName">
        /// The name of the target node to add
        /// </param>
        /// <param name="targetNodeSummary">
        /// The summary of the target node to add
        /// </param>
        /// <param name="targetNodeUuid">
        /// The target node uuid
        /// </param>
        /// <param name="userId"></param>
        /// <param name="validAt">
        /// The time at which the fact becomes true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddTripleRequest(
            string fact,
            string factName,
            string? createdAt,
            object? edgeAttributes,
            string? expiredAt,
            string? factUuid,
            string? graphId,
            string? invalidAt,
            object? metadata,
            object? sourceNodeAttributes,
            global::System.Collections.Generic.IList<string>? sourceNodeLabels,
            string? sourceNodeName,
            string? sourceNodeSummary,
            string? sourceNodeUuid,
            object? targetNodeAttributes,
            global::System.Collections.Generic.IList<string>? targetNodeLabels,
            string? targetNodeName,
            string? targetNodeSummary,
            string? targetNodeUuid,
            string? userId,
            string? validAt)
        {
            this.CreatedAt = createdAt;
            this.EdgeAttributes = edgeAttributes;
            this.ExpiredAt = expiredAt;
            this.Fact = fact ?? throw new global::System.ArgumentNullException(nameof(fact));
            this.FactName = factName ?? throw new global::System.ArgumentNullException(nameof(factName));
            this.FactUuid = factUuid;
            this.GraphId = graphId;
            this.InvalidAt = invalidAt;
            this.Metadata = metadata;
            this.SourceNodeAttributes = sourceNodeAttributes;
            this.SourceNodeLabels = sourceNodeLabels;
            this.SourceNodeName = sourceNodeName;
            this.SourceNodeSummary = sourceNodeSummary;
            this.SourceNodeUuid = sourceNodeUuid;
            this.TargetNodeAttributes = targetNodeAttributes;
            this.TargetNodeLabels = targetNodeLabels;
            this.TargetNodeName = targetNodeName;
            this.TargetNodeSummary = targetNodeSummary;
            this.TargetNodeUuid = targetNodeUuid;
            this.UserId = userId;
            this.ValidAt = validAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddTripleRequest" /> class.
        /// </summary>
        public GraphitiAddTripleRequest()
        {
        }
    }
}