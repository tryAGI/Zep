
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUpdateEdgeRequest
    {
        /// <summary>
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Updated time at which the edge expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public string? ExpiredAt { get; set; }

        /// <summary>
        /// Updated fact for the edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact")]
        public string? Fact { get; set; }

        /// <summary>
        /// Updated time at which the fact stopped being true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_at")]
        public string? InvalidAt { get; set; }

        /// <summary>
        /// Updated name (relationship type) for the edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated time at which the fact becomes true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        public string? ValidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateEdgeRequest" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </param>
        /// <param name="expiredAt">
        /// Updated time at which the edge expires
        /// </param>
        /// <param name="fact">
        /// Updated fact for the edge
        /// </param>
        /// <param name="invalidAt">
        /// Updated time at which the fact stopped being true
        /// </param>
        /// <param name="name">
        /// Updated name (relationship type) for the edge
        /// </param>
        /// <param name="validAt">
        /// Updated time at which the fact becomes true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUpdateEdgeRequest(
            object? attributes,
            string? expiredAt,
            string? fact,
            string? invalidAt,
            string? name,
            string? validAt)
        {
            this.Attributes = attributes;
            this.ExpiredAt = expiredAt;
            this.Fact = fact;
            this.InvalidAt = invalidAt;
            this.Name = name;
            this.ValidAt = validAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateEdgeRequest" /> class.
        /// </summary>
        public ApidataUpdateEdgeRequest()
        {
        }
    }
}