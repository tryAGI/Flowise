#nullable enable

namespace Flowise
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// List all chatflows<br/>
        /// Retrieve a list of all chatflows
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.Chatflow>> ListChatflowsAsync(
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}