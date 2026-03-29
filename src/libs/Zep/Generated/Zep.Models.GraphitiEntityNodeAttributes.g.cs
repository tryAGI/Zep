
#nullable enable

namespace Zep
{
    /// <summary>
    /// Additional attributes of the node. Dependent on node labels
    /// </summary>
    public sealed partial class GraphitiEntityNodeAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}