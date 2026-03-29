#nullable enable

namespace Zep
{
    public partial interface ISubpackageEntityClient
    {
        /// <summary>
        /// Get Node<br/>
        /// Returns a specific node by its UUID.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.GraphitiEntityNode> GetNodeAsync(
            string uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}