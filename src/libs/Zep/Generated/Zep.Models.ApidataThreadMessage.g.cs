
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataThreadMessage
    {
        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The timestamp of when the message was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The metadata associated with the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Customizable name of the sender of the message (e.g., "john", "sales_agent").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the message has been processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed")]
        public bool? Processed { get; set; }

        /// <summary>
        /// The role of message sender (e.g., "user", "system").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ApidataRoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.ApidataRoleType Role { get; set; }

        /// <summary>
        /// The unique identifier of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="role">
        /// The role of message sender (e.g., "user", "system").
        /// </param>
        /// <param name="createdAt">
        /// The timestamp of when the message was created.
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the message.
        /// </param>
        /// <param name="name">
        /// Customizable name of the sender of the message (e.g., "john", "sales_agent").
        /// </param>
        /// <param name="processed">
        /// Whether the message has been processed.
        /// </param>
        /// <param name="uuid">
        /// The unique identifier of the message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadMessage(
            string content,
            global::Zep.ApidataRoleType role,
            string? createdAt,
            object? metadata,
            string? name,
            bool? processed,
            string? uuid)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
            this.Name = name;
            this.Processed = processed;
            this.Role = role;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadMessage" /> class.
        /// </summary>
        public ApidataThreadMessage()
        {
        }

    }
}