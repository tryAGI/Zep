
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataAddThreadMessagesRequest
    {
        /// <summary>
        /// Optional list of role types to ignore when adding messages to graph memory.<br/>
        /// The message itself will still be added, retained and used as context for messages<br/>
        /// that are added to a user's graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_roles")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? IgnoreRoles { get; set; }

        /// <summary>
        /// A list of message objects, where each message contains a role and content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage> Messages { get; set; }

        /// <summary>
        /// Optionally return context block relevant to the most recent messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_context")]
        public bool? ReturnContext { get; set; }

        /// <summary>
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_ontology")]
        public bool? StrictOntology { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddThreadMessagesRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of message objects, where each message contains a role and content.
        /// </param>
        /// <param name="ignoreRoles">
        /// Optional list of role types to ignore when adding messages to graph memory.<br/>
        /// The message itself will still be added, retained and used as context for messages<br/>
        /// that are added to a user's graph.
        /// </param>
        /// <param name="returnContext">
        /// Optionally return context block relevant to the most recent messages.
        /// </param>
        /// <param name="strictOntology">
        /// When true, prevents extraction of generic Entity nodes that do not match the configured ontology.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataAddThreadMessagesRequest(
            global::System.Collections.Generic.IList<global::Zep.ApidataThreadMessage> messages,
            global::System.Collections.Generic.IList<global::Zep.ApidataRoleType>? ignoreRoles,
            bool? returnContext,
            bool? strictOntology)
        {
            this.IgnoreRoles = ignoreRoles;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.ReturnContext = returnContext;
            this.StrictOntology = strictOntology;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataAddThreadMessagesRequest" /> class.
        /// </summary>
        public ApidataAddThreadMessagesRequest()
        {
        }

    }
}