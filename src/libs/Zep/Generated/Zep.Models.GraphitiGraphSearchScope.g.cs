
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
        Edges,
        /// <summary>
        /// 
        /// </summary>
        Episodes,
        /// <summary>
        /// 
        /// </summary>
        Nodes,
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
                GraphitiGraphSearchScope.Edges => "edges",
                GraphitiGraphSearchScope.Episodes => "episodes",
                GraphitiGraphSearchScope.Nodes => "nodes",
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
                "edges" => GraphitiGraphSearchScope.Edges,
                "episodes" => GraphitiGraphSearchScope.Episodes,
                "nodes" => GraphitiGraphSearchScope.Nodes,
                _ => null,
            };
        }
    }
}