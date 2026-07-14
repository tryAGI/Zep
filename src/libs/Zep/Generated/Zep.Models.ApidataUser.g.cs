
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public string? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_default_ontology")]
        public bool? DisableDefaultOntology { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        public int? SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUser" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="deletedAt"></param>
        /// <param name="disableDefaultOntology"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="id"></param>
        /// <param name="lastName"></param>
        /// <param name="metadata">
        /// Deprecated
        /// </param>
        /// <param name="projectUuid"></param>
        /// <param name="sessionCount">
        /// Deprecated
        /// </param>
        /// <param name="timeZone"></param>
        /// <param name="updatedAt">
        /// Deprecated
        /// </param>
        /// <param name="userId"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUser(
            string? createdAt,
            string? deletedAt,
            bool? disableDefaultOntology,
            string? email,
            string? firstName,
            int? id,
            string? lastName,
            object? metadata,
            string? projectUuid,
            int? sessionCount,
            string? timeZone,
            string? updatedAt,
            string? userId,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.DisableDefaultOntology = disableDefaultOntology;
            this.Email = email;
            this.FirstName = firstName;
            this.Id = id;
            this.LastName = lastName;
            this.Metadata = metadata;
            this.ProjectUuid = projectUuid;
            this.SessionCount = sessionCount;
            this.TimeZone = timeZone;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUser" /> class.
        /// </summary>
        public ApidataUser()
        {
        }

    }
}