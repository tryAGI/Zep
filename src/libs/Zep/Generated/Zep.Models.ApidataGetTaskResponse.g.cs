
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGetTaskResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Zep.ApidataTaskErrorResponse? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Zep.ApidataTaskProgress? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGetTaskResponse" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="error"></param>
        /// <param name="params"></param>
        /// <param name="progress"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGetTaskResponse(
            string? completedAt,
            string? createdAt,
            global::Zep.ApidataTaskErrorResponse? error,
            object? @params,
            global::Zep.ApidataTaskProgress? progress,
            string? startedAt,
            string? status,
            string? taskId,
            string? type,
            string? updatedAt)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.Params = @params;
            this.Progress = progress;
            this.StartedAt = startedAt;
            this.Status = status;
            this.TaskId = taskId;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGetTaskResponse" /> class.
        /// </summary>
        public ApidataGetTaskResponse()
        {
        }
    }
}