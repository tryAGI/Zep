
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraphEpisodeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>? Episodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisodeResponse" /> class.
        /// </summary>
        /// <param name="episodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraphEpisodeResponse(
            global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>? episodes)
        {
            this.Episodes = episodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraphEpisodeResponse" /> class.
        /// </summary>
        public ApidataGraphEpisodeResponse()
        {
        }

    }
}