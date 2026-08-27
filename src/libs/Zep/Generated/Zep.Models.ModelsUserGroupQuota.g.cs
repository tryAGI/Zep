
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsUserGroupQuota
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_managed")]
        public int? ActiveManaged { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocation")]
        public int? Allocation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_feature")]
        public bool? HasFeature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public bool? Resolved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlimited")]
        public bool? Unlimited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsUserGroupQuota" /> class.
        /// </summary>
        /// <param name="activeManaged"></param>
        /// <param name="allocation"></param>
        /// <param name="hasFeature"></param>
        /// <param name="resolved"></param>
        /// <param name="unlimited"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsUserGroupQuota(
            int? activeManaged,
            int? allocation,
            bool? hasFeature,
            bool? resolved,
            bool? unlimited)
        {
            this.ActiveManaged = activeManaged;
            this.Allocation = allocation;
            this.HasFeature = hasFeature;
            this.Resolved = resolved;
            this.Unlimited = unlimited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsUserGroupQuota" /> class.
        /// </summary>
        public ModelsUserGroupQuota()
        {
        }

    }
}