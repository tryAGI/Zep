
#nullable enable

namespace Zep
{
    /// <summary>
    /// Property value to match on. Accepted types: string, int, float64, bool, or nil.<br/>
    /// Invalid types (e.g., arrays, objects) will be rejected by validation.<br/>
    /// Must be non-nil for non-null operators (`=`, `&lt;&gt;`, `&gt;`, `&lt;`, `&gt;=`, `&lt;=`).
    /// </summary>
    public sealed partial class GraphitiPropertyFilterPropertyValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}