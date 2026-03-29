
#nullable enable

namespace Zep
{
    /// <summary>
    /// 
    /// </summary>
    public enum GraphitiReranker
    {
        /// <summary>
        /// 
        /// </summary>
        CrossEncoder,
        /// <summary>
        /// 
        /// </summary>
        EpisodeMentions,
        /// <summary>
        /// 
        /// </summary>
        Mmr,
        /// <summary>
        /// 
        /// </summary>
        NodeDistance,
        /// <summary>
        /// 
        /// </summary>
        Rrf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphitiRerankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphitiReranker value)
        {
            return value switch
            {
                GraphitiReranker.CrossEncoder => "cross_encoder",
                GraphitiReranker.EpisodeMentions => "episode_mentions",
                GraphitiReranker.Mmr => "mmr",
                GraphitiReranker.NodeDistance => "node_distance",
                GraphitiReranker.Rrf => "rrf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphitiReranker? ToEnum(string value)
        {
            return value switch
            {
                "cross_encoder" => GraphitiReranker.CrossEncoder,
                "episode_mentions" => GraphitiReranker.EpisodeMentions,
                "mmr" => GraphitiReranker.Mmr,
                "node_distance" => GraphitiReranker.NodeDistance,
                "rrf" => GraphitiReranker.Rrf,
                _ => null,
            };
        }
    }
}