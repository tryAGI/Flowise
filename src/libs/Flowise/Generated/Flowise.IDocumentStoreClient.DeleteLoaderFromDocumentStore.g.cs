#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Delete specific document loader and associated chunks from document store<br/>
        /// Delete specific document loader and associated chunks from document store. This does not delete data from vector store.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLoaderFromDocumentStoreAsync(
            string storeId,
            string loaderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}