#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Delete a specific chunk from a document loader<br/>
        /// Delete a specific chunk from a document loader
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="chunkId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDocumentStoreFileChunkAsync(
            string storeId,
            string loaderId,
            string chunkId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}