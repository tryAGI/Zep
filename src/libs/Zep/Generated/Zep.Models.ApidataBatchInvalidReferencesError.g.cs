
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataBatchInvalidReferencesError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_items")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataBatchInvalidItem>? InvalidItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchInvalidReferencesError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="invalidItems"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchInvalidReferencesError(
            string? code,
            global::System.Collections.Generic.IList<global::Zep.ApidataBatchInvalidItem>? invalidItems,
            string? message)
        {
            this.Code = code;
            this.InvalidItems = invalidItems;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchInvalidReferencesError" /> class.
        /// </summary>
        public ApidataBatchInvalidReferencesError()
        {
        }

    }
}