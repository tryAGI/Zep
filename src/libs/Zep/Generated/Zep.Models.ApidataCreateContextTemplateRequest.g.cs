
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataCreateContextTemplateRequest
    {
        /// <summary>
        /// The template content (max 1200 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Unique identifier for the template (max 100 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateContextTemplateRequest" /> class.
        /// </summary>
        /// <param name="template">
        /// The template content (max 1200 characters).
        /// </param>
        /// <param name="templateId">
        /// Unique identifier for the template (max 100 characters).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCreateContextTemplateRequest(
            string template,
            string templateId)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCreateContextTemplateRequest" /> class.
        /// </summary>
        public ApidataCreateContextTemplateRequest()
        {
        }
    }
}