
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataGraph
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_id")]
        public string? GraphId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraph" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="graphId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectUuid"></param>
        /// <param name="timeZone"></param>
        /// <param name="updatedAt"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataGraph(
            string? createdAt,
            string? description,
            string? graphId,
            int? id,
            string? name,
            string? projectUuid,
            string? timeZone,
            string? updatedAt,
            string? uuid)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.GraphId = graphId;
            this.Id = id;
            this.Name = name;
            this.ProjectUuid = projectUuid;
            this.TimeZone = timeZone;
            this.UpdatedAt = updatedAt;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataGraph" /> class.
        /// </summary>
        public ApidataGraph()
        {
        }

    }
}