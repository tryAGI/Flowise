#nullable enable

namespace Flowise
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Delete a chatflow<br/>
        /// Delete a chatflow by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChatflowAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}