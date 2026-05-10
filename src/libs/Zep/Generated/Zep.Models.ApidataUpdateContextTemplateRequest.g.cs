
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUpdateContextTemplateRequest
    {
        /// <summary>
        /// The template content (max 1200 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateContextTemplateRequest" /> class.
        /// </summary>
        /// <param name="template">
        /// The template content (max 1200 characters).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUpdateContextTemplateRequest(
            string template)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateContextTemplateRequest" /> class.
        /// </summary>
        public ApidataUpdateContextTemplateRequest()
        {
        }

    }
}