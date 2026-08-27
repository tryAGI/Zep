
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataCreateUserRequest
    {
        /// <summary>
        /// When true, disables the use of default/fallback ontology for the user's graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_default_ontology")]
        public bool? DisableDefaultOntology { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// The metadata associated with the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The user's IANA time zone. Null or omission leaves it unset at creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateUserRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="disableDefaultOntology">
        /// When true, disables the use of default/fallback ontology for the user's graph.
        /// </param>
        /// <param name="email">
        /// The email address of the user.
        /// </param>
        /// <param name="firstName">
        /// The first name of the user.
        /// </param>
        /// <param name="lastName">
        /// The last name of the user.
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the user.
        /// </param>
        /// <param name="timeZone">
        /// The user's IANA time zone. Null or omission leaves it unset at creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCreateUserRequest(
            string userId,
            bool? disableDefaultOntology,
            string? email,
            string? firstName,
            string? lastName,
            object? metadata,
            string? timeZone)
        {
            this.DisableDefaultOntology = disableDefaultOntology;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Metadata = metadata;
            this.TimeZone = timeZone;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateUserRequest" /> class.
        /// </summary>
        public ApidataCreateUserRequest()
        {
        }

    }
}