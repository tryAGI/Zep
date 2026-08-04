
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUpdateUserGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpectedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateUserGroupRequest" /> class.
        /// </summary>
        /// <param name="expectedVersion"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUpdateUserGroupRequest(
            int expectedVersion,
            string? description,
            string? name)
        {
            this.Description = description;
            this.ExpectedVersion = expectedVersion;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateUserGroupRequest" /> class.
        /// </summary>
        public ApidataUpdateUserGroupRequest()
        {
        }

    }
}