#nullable enable

namespace Flowise
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Get chatflow by ID<br/>
        /// Retrieve a specific chatflow by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.Chatflow> GetChatflowByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}