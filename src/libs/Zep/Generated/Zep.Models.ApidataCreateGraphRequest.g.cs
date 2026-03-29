
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCreateGraphRequest(
            string graphId,
            string? description,
            string? name)
        {
            this.Description = description;
            this.GraphId = graphId ?? throw new global::System.ArgumentNullException(nameof(graphId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateGraphRequest" /> class.
        /// </summary>
        public ApidataCreateGraphRequest()
        {
        }
    }
}