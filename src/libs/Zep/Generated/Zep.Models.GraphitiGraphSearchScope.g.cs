
#nullable enable

namespace Zep
{
    /// <summary>
    ///
    /// </summary>
    public enum GraphitiGraphSearchScope
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Edges,
        /// <summary>
        ///
        /// </summary>
        Episodes,
        /// <summary>
        ///
        /// </summary>
        Nodes,
        /// <summary>
        ///
        /// </summary>
        Observations,
        /// <summary>
        ///
        /// </summary>
        ThreadSummaries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphitiGraphSearchScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphitiGraphSearchScope value)
        {
            return value switch
            {
                GraphitiGraphSearchScope.Auto => "auto",
                GraphitiGraphSearchScope.Edges => "edges",
                GraphitiGraphSearchScope.Episodes => "episodes",
                GraphitiGraphSearchScope.Nodes => "nodes",
                GraphitiGraphSearchScope.Observations => "observations",
                GraphitiGraphSearchScope.ThreadSummaries => "thread_summaries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphitiGraphSearchScope? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GraphitiGraphSearchScope.Auto,
                "edges" => GraphitiGraphSearchScope.Edges,
                "episodes" => GraphitiGraphSearchScope.Episodes,
                "nodes" => GraphitiGraphSearchScope.Nodes,
                "observations" => GraphitiGraphSearchScope.Observations,
                "thread_summaries" => GraphitiGraphSearchScope.ThreadSummaries,
                _ => null,
            };
        }
    }
}