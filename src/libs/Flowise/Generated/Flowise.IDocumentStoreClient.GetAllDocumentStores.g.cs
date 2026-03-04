#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// List all document stores<br/>
        /// Retrieves a list of all document stores
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.DocumentStore>> GetAllDocumentStoresAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}