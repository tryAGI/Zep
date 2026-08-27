
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsBatchItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsBatchItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsBatchItemStatus value)
        {
            return value switch
            {
                ModelsBatchItemStatus.Canceled => "canceled",
                ModelsBatchItemStatus.Failed => "failed",
                ModelsBatchItemStatus.Pending => "pending",
                ModelsBatchItemStatus.Processing => "processing",
                ModelsBatchItemStatus.Queued => "queued",
                ModelsBatchItemStatus.Skipped => "skipped",
                ModelsBatchItemStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsBatchItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ModelsBatchItemStatus.Canceled,
                "failed" => ModelsBatchItemStatus.Failed,
                "pending" => ModelsBatchItemStatus.Pending,
                "processing" => ModelsBatchItemStatus.Processing,
                "queued" => ModelsBatchItemStatus.Queued,
                "skipped" => ModelsBatchItemStatus.Skipped,
                "succeeded" => ModelsBatchItemStatus.Succeeded,
                _ => null,
            };
        }
    }
}