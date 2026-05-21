
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApidataBatchProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_items")]
        public int? FailedItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_complete")]
        public double? PercentComplete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_items")]
        public int? ProcessingItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_items")]
        public int? QueuedItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_items")]
        public int? SkippedItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded_items")]
        public int? SucceededItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchProgress" /> class.
        /// </summary>
        /// <param name="failedItems"></param>
        /// <param name="percentComplete"></param>
        /// <param name="processingItems"></param>
        /// <param name="queuedItems"></param>
        /// <param name="skippedItems"></param>
        /// <param name="succeededItems"></param>
        /// <param name="totalItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApidataBatchProgress(
            int? failedItems,
            double? percentComplete,
            int? processingItems,
            int? queuedItems,
            int? skippedItems,
            int? succeededItems,
            int? totalItems)
        {
            this.FailedItems = failedItems;
            this.PercentComplete = percentComplete;
            this.ProcessingItems = processingItems;
            this.QueuedItems = queuedItems;
            this.SkippedItems = skippedItems;
            this.SucceededItems = succeededItems;
            this.TotalItems = totalItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApidataBatchProgress" /> class.
        /// </summary>
        public ApidataBatchProgress()
        {
        }

    }
}