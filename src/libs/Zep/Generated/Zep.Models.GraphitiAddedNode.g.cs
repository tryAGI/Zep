
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiAddedNode
    {
        /// <summary>
        /// Additional attributes of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The node creation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The node's entity type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Metadata attached to the node's shadow episode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A regional summary of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The node UUID, assigned by Zep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddedNode" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the node.
        /// </param>
        /// <param name="attributes">
        /// Additional attributes of the node.
        /// </param>
        /// <param name="createdAt">
        /// The node creation time.
        /// </param>
        /// <param name="label">
        /// The node's entity type.
        /// </param>
        /// <param name="metadata">
        /// Metadata attached to the node's shadow episode.
        /// </param>
        /// <param name="summary">
        /// A regional summary of the node.
        /// </param>
        /// <param name="uuid">
        /// The node UUID, assigned by Zep.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddedNode(
            string name,
            object? attributes,
            string? createdAt,
            string? label,
            object? metadata,
            string? summary,
            string? uuid)
        {
            this.Attributes = attributes;
            this.CreatedAt = createdAt;
            this.Label = label;
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Summary = summary;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddedNode" /> class.
        /// </summary>
        public GraphitiAddedNode()
        {
        }

    }
}