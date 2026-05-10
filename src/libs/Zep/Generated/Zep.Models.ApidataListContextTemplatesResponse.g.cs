
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataListContextTemplatesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataContextTemplateResponse>? Templates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataListContextTemplatesResponse" /> class.
        /// </summary>
        /// <param name="templates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataListContextTemplatesResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataContextTemplateResponse>? templates)
        {
            this.Templates = templates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataListContextTemplatesResponse" /> class.
        /// </summary>
        public ApidataListContextTemplatesResponse()
        {
        }

    }
}