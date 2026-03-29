#nullable enable

namespace Zep
{
    public partial interface ISubpackageProjectClient
    {
        /// <summary>
        /// Retrieves project information<br/>
        /// Retrieve project info based on the provided api key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Zep.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Zep.ApidataProjectInfoResponse> RetrievesProjectInformationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}