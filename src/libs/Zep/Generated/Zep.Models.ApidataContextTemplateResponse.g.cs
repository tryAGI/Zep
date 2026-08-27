
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataContextTemplateResponse
    {
        /// <summary>
        /// The template content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// Unique identifier for the template (max 100 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Unique identifier for the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataContextTemplateResponse" /> class.
        /// </summary>
        /// <param name="template">
        /// The template content.
        /// </param>
        /// <param name="templateId">
        /// Unique identifier for the template (max 100 characters).
        /// </param>
        /// <param name="uuid">
        /// Unique identifier for the template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataContextTemplateResponse(
            string? template,
            string? templateId,
            string? uuid)
        {
            this.Template = template;
            this.TemplateId = templateId;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataContextTemplateResponse" /> class.
        /// </summary>
        public ApidataContextTemplateResponse()
        {
        }

    }
}