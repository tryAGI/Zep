
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUserGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_policy_set_count")]
        public int? AttachedPolicySetCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.ModelsUserGroupKindJsonConverter))]
        public global::Zep.ModelsUserGroupKind? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupResponse" /> class.
        /// </summary>
        /// <param name="attachedPolicySetCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="kind"></param>
        /// <param name="memberCount"></param>
        /// <param name="name"></param>
        /// <param name="projectUuid"></param>
        /// <param name="updatedAt"></param>
        /// <param name="uuid"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUserGroupResponse(
            int? attachedPolicySetCount,
            string? createdAt,
            string? description,
            global::Zep.ModelsUserGroupKind? kind,
            int? memberCount,
            string? name,
            string? projectUuid,
            string? updatedAt,
            string? uuid,
            int? version)
        {
            this.AttachedPolicySetCount = attachedPolicySetCount;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Kind = kind;
            this.MemberCount = memberCount;
            this.Name = name;
            this.ProjectUuid = projectUuid;
            this.UpdatedAt = updatedAt;
            this.Uuid = uuid;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUserGroupResponse" /> class.
        /// </summary>
        public ApidataUserGroupResponse()
        {
        }

    }
}