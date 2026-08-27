
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataCreateGraphRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GraphId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The graph's IANA time zone. Stored on its group-backed subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateGraphRequest" /> class.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="timeZone">
        /// The graph's IANA time zone. Stored on its group-backed subject.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCreateGraphRequest(
            string graphId,
            string? description,
            string? name,
            string? timeZone)
        {
            this.Description = description;
            this.GraphId = graphId ?? throw new global::System.ArgumentNullException(nameof(graphId));
            this.Name = name;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateGraphRequest" /> class.
        /// </summary>
        public ApidataCreateGraphRequest()
        {
        }

    }
}