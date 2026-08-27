
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApidataThreadListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_count")]
        public int? ResponseCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threads")]
        public global::System.Collections.Generic.IList<global::Zep.ApidataThread>? Threads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadListResponse" /> class.
        /// </summary>
        /// <param name="responseCount"></param>
        /// <param name="threads"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataThreadListResponse(
            int? responseCount,
            global::System.Collections.Generic.IList<global::Zep.ApidataThread>? threads,
            int? totalCount)
        {
            this.ResponseCount = responseCount;
            this.Threads = threads;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataThreadListResponse" /> class.
        /// </summary>
        public ApidataThreadListResponse()
        {
        }

    }
}