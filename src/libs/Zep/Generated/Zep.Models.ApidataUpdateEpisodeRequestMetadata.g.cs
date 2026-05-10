
#nullable enable

namespace Zep
{
    /// <summary>
    /// Updated metadata. Merged with existing metadata: supplied keys overwrite/add, keys set to null are removed. Maximum 10 keys. Values must be scalars (string, number, boolean, null) or arrays of scalars.
    /// </summary>
    public sealed partial class ApidataUpdateEpisodeRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}