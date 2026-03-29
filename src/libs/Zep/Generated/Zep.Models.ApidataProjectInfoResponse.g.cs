
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataProjectInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Zep.ApidataProjectInfo? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataProjectInfoResponse" /> class.
        /// </summary>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataProjectInfoResponse(
            global::Zep.ApidataProjectInfo? project)
        {
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataProjectInfoResponse" /> class.
        /// </summary>
        public ApidataProjectInfoResponse()
        {
        }
    }
}