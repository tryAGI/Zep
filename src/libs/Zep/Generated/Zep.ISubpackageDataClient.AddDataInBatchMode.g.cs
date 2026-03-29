#nullable enable

namespace Zep
{
    public partial interface ISubpackageDataClient
    {
        /// <summary>
        /// Add Data in batch mode<br/>
        /// Add data to the graph in batch mode. Episodes are processed sequentially in the order provided.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> AddDataInBatchModeAsync(

            global::Zep.ApidataAddDataBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Data in batch mode<br/>
        /// Add data to the graph in batch mode. Episodes are processed sequentially in the order provided.
        /// </summary>
        /// <param name="episodes"></param>
        /// <param name="graphId">
        /// graph_id is the ID of the graph to which the data will be added. If adding to the user graph, please use user_id field instead.
        /// </param>
        /// <param name="userId">
        /// User ID is the ID of the user to which the data will be added. If not adding to a user graph, please use graph_id field instead.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Zep.ApidataGraphEpisode>> AddDataInBatchModeAsync(
            global::System.Collections.Generic.IList<global::Zep.ApidataEpisodeData> episodes,
            string? graphId = default,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}