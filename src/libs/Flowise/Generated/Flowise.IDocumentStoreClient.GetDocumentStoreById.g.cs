#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Get a specific document store<br/>
        /// Retrieves details of a specific document store by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.DocumentStore> GetDocumentStoreByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}