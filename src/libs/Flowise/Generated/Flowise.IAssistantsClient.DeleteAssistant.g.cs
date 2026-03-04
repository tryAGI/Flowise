#nullable enable

namespace Flowise
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Delete an assistant<br/>
        /// Delete an assistant by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAssistantAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}