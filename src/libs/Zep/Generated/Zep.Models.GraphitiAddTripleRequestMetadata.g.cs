
#nullable enable

namespace Zep
{
    /// <summary>
    /// Optional metadata key-value pairs for the shadow episode created for this fact triple.<br/>
    /// Max 10 keys. Values must be strings, numbers, or booleans.
    /// </summary>
    public sealed partial class GraphitiAddTripleRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}