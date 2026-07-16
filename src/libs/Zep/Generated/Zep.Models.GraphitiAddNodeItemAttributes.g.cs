
#nullable enable

namespace Zep
{
    /// <summary>
    /// Additional attributes of the node. Values must be scalar types (string,<br/>
    /// number, boolean, or null). Nested objects and arrays are not allowed.
    /// </summary>
    public sealed partial class GraphitiAddNodeItemAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}