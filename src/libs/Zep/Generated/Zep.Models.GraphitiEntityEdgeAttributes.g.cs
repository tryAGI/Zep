
#nullable enable

namespace Zep
{
    /// <summary>
    /// Additional attributes of the edge. Dependent on edge types
    /// </summary>
    public sealed partial class GraphitiEntityEdgeAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}