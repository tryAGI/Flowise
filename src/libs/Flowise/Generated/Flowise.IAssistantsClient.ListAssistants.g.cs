#nullable enable

namespace Flowise
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// List all assistants<br/>
        /// Retrieve a list of all assistants
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.Assistant>> ListAssistantsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}