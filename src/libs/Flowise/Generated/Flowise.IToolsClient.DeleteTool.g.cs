#nullable enable

namespace Flowise
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete a tool by ID<br/>
        /// Delete a specific tool by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteToolAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}