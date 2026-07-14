
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataUpdateProjectInfoRequest
    {
        /// <summary>
        /// The project's IANA fallback time zone. Null clears the existing value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_time_zone")]
        public string? DefaultTimeZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateProjectInfoRequest" /> class.
        /// </summary>
        /// <param name="defaultTimeZone">
        /// The project's IANA fallback time zone. Null clears the existing value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataUpdateProjectInfoRequest(
            string? defaultTimeZone)
        {
            this.DefaultTimeZone = defaultTimeZone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataUpdateProjectInfoRequest" /> class.
        /// </summary>
        public ApidataUpdateProjectInfoRequest()
        {
        }

    }
}