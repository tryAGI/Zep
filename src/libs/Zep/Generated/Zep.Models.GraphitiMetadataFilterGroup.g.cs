
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphitiMetadataFilterGroup
    {
        /// <summary>
        /// Leaf filters (predicates on metadata key-value pairs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiEpisodeMetadataFilter>? Filters { get; set; }

        /// <summary>
        /// Nested sub-groups for composing complex boolean expressions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Zep.GraphitiMetadataFilterGroup>? Groups { get; set; }

        /// <summary>
        /// Logical operator: "and" or "or"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Zep.JsonConverters.GraphitiMetadataFilterGroupTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Zep.GraphitiMetadataFilterGroupType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiMetadataFilterGroup" /> class.
        /// </summary>
        /// <param name="type">
        /// Logical operator: "and" or "or"
        /// </param>
        /// <param name="filters">
        /// Leaf filters (predicates on metadata key-value pairs)
        /// </param>
        /// <param name="groups">
        /// Nested sub-groups for composing complex boolean expressions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphitiMetadataFilterGroup(
            global::Zep.GraphitiMetadataFilterGroupType type,
            global::System.Collections.Generic.IList<global::Zep.GraphitiEpisodeMetadataFilter>? filters,
            global::System.Collections.Generic.IList<global::Zep.GraphitiMetadataFilterGroup>? groups)
        {
            this.Filters = filters;
            this.Groups = groups;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphitiMetadataFilterGroup" /> class.
        /// </summary>
        public GraphitiMetadataFilterGroup()
        {
        }
    }
}