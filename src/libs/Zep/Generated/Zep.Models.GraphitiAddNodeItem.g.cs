
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiAddNodeItem
    {
        /// <summary>
        /// Additional attributes of the node. Values must be scalar types (string,<br/>
        /// number, boolean, or null). Nested objects and arrays are not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The node creation time. Defaults to the request time when absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The node's entity type. At most one; the base "Entity" label is added<br/>
        /// implicitly by the graph layer on save and does not need to be supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional metadata attached to the node's shadow episode. Max 10 scalar<br/>
        /// key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the node. Used to derive the node's search embedding.
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
        /// Optional caller-supplied node UUID. When it matches an existing node the<br/>
        /// node is upserted; when well-formed but unknown the node is created with<br/>
        /// this UUID; when absent the server assigns one. This is the node's only<br/>
        /// identity/dedup key -- there is no name-based resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiAddNodeItem" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the node. Used to derive the node's search embedding.
        /// </param>
        /// <param name="attributes">
        /// Additional attributes of the node. Values must be scalar types (string,<br/>
        /// number, boolean, or null). Nested objects and arrays are not allowed.
        /// </param>
        /// <param name="createdAt">
        /// The node creation time. Defaults to the request time when absent.
        /// </param>
        /// <param name="label">
        /// The node's entity type. At most one; the base "Entity" label is added<br/>
        /// implicitly by the graph layer on save and does not need to be supplied.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata attached to the node's shadow episode. Max 10 scalar<br/>
        /// key-value pairs.
        /// </param>
        /// <param name="summary">
        /// A regional summary of the node.
        /// </param>
        /// <param name="uuid">
        /// Optional caller-supplied node UUID. When it matches an existing node the<br/>
        /// node is upserted; when well-formed but unknown the node is created with<br/>
        /// this UUID; when absent the server assigns one. This is the node's only<br/>
        /// identity/dedup key -- there is no name-based resolution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiAddNodeItem(
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
        /// Initializes a new instance of the <see cref="GraphitiAddNodeItem" /> class.
        /// </summary>
        public GraphitiAddNodeItem()
        {
        }

    }
}