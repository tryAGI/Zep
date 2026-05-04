
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelsBatchItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        GraphEpisode,
        /// <summary>
        /// 
        /// </summary>
        ThreadMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsBatchItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsBatchItemKind value)
        {
            return value switch
            {
                ModelsBatchItemKind.GraphEpisode => "graph_episode",
                ModelsBatchItemKind.ThreadMessage => "thread_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsBatchItemKind? ToEnum(string value)
        {
            return value switch
            {
                "graph_episode" => ModelsBatchItemKind.GraphEpisode,
                "thread_message" => ModelsBatchItemKind.ThreadMessage,
                _ => null,
            };
        }
    }
}