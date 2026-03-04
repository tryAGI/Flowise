#nullable enable

namespace Flowise
{
    public partial interface IChatflowsClient
    {
        /// <summary>
        /// List all chatflows<br/>
        /// Retrieve a list of all chatflows
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.Chatflow>> ListChatflowsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}