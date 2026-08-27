
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataUpdateNodeRequest
    {
        /// <summary>
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Updated labels for the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Updated name for the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated summary for the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateNodeRequest" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Updated attributes. Merged with existing attributes. Set a key to null to delete it.
        /// </param>
        /// <param name="labels">
        /// Updated labels for the node
        /// </param>
        /// <param name="name">
        /// Updated name for the node
        /// </param>
        /// <param name="summary">
        /// Updated summary for the node
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUpdateNodeRequest(
            object? attributes,
            global::System.Collections.Generic.IList<string>? labels,
            string? name,
            string? summary)
        {
            this.Attributes = attributes;
            this.Labels = labels;
            this.Name = name;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateNodeRequest" /> class.
        /// </summary>
        public ApidataUpdateNodeRequest()
        {
        }

    }
}