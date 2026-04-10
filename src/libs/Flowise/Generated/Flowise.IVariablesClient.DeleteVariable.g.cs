#nullable enable

namespace Flowise
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// Delete a variable by ID<br/>
        /// Delete a specific variable by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVariableAsync(
            string id,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}