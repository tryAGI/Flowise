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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.Chatflow> GetChatflowByApiKeyAsync(
            string apikey,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}