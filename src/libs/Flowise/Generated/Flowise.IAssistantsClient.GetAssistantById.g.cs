#nullable enable

namespace Flowise
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Get assistant by ID<br/>
        /// Retrieve a specific assistant by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.Assistant> GetAssistantByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}