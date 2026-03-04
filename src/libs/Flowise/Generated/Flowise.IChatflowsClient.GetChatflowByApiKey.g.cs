#nullable enable

namespace Flowise
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// Get chatflow by API key<br/>
        /// Retrieve a chatflow using an API key
        /// </summary>
        /// <param name="apikey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.Chatflow> GetChatflowByApiKeyAsync(
            string apikey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}