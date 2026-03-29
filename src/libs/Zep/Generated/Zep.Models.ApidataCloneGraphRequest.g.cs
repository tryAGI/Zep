
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataCloneGraphRequest
    {
        /// <summary>
        /// source_graph_id is the ID of the graph to be cloned. Required if source_user_id is not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_graph_id")]
        public string? SourceGraphId { get; set; }

        /// <summary>
        /// user_id of the user whose graph is being cloned. Required if source_graph_id is not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_user_id")]
        public string? SourceUserId { get; set; }

        /// <summary>
        /// target_graph_id is the ID to be set on the cloned graph. Must not point to an existing graph. Required if target_user_id is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_graph_id")]
        public string? TargetGraphId { get; set; }

        /// <summary>
        /// user_id to be set on the cloned user. Must not point to an existing user. Required if target_graph_id is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_user_id")]
        public string? TargetUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCloneGraphRequest" /> class.
        /// </summary>
        /// <param name="sourceGraphId">
        /// source_graph_id is the ID of the graph to be cloned. Required if source_user_id is not provided
        /// </param>
        /// <param name="sourceUserId">
        /// user_id of the user whose graph is being cloned. Required if source_graph_id is not provided
        /// </param>
        /// <param name="targetGraphId">
        /// target_graph_id is the ID to be set on the cloned graph. Must not point to an existing graph. Required if target_user_id is not provided.
        /// </param>
        /// <param name="targetUserId">
        /// user_id to be set on the cloned user. Must not point to an existing user. Required if target_graph_id is not provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataCloneGraphRequest(
            string? sourceGraphId,
            string? sourceUserId,
            string? targetGraphId,
            string? targetUserId)
        {
            this.SourceGraphId = sourceGraphId;
            this.SourceUserId = sourceUserId;
            this.TargetGraphId = targetGraphId;
            this.TargetUserId = targetUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataCloneGraphRequest" /> class.
        /// </summary>
        public ApidataCloneGraphRequest()
        {
        }
    }
}