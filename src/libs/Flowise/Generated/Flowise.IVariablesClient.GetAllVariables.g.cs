#nullable enable

namespace Flowise
{
    public partial interface IVariablesClient
    {
        /// <summary>
        /// List all variables<br/>
        /// Retrieve a list of all variables
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.Variable>> GetAllVariablesAsync(
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}