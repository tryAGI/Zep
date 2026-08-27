
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsBatchStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Draft,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        Partial,
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
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsBatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsBatchStatus value)
        {
            return value switch
            {
                ModelsBatchStatus.Canceled => "canceled",
                ModelsBatchStatus.Draft => "draft",
                ModelsBatchStatus.Failed => "failed",
                ModelsBatchStatus.Invalid => "invalid",
                ModelsBatchStatus.Partial => "partial",
                ModelsBatchStatus.Processing => "processing",
                ModelsBatchStatus.Queued => "queued",
                ModelsBatchStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsBatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ModelsBatchStatus.Canceled,
                "draft" => ModelsBatchStatus.Draft,
                "failed" => ModelsBatchStatus.Failed,
                "invalid" => ModelsBatchStatus.Invalid,
                "partial" => ModelsBatchStatus.Partial,
                "processing" => ModelsBatchStatus.Processing,
                "queued" => ModelsBatchStatus.Queued,
                "succeeded" => ModelsBatchStatus.Succeeded,
                _ => null,
            };
        }
    }
}