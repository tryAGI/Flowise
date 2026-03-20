#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Update a specific chunk<br/>
        /// Updates a specific chunk from a document loader
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="chunkId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.DocumentStoreFileChunkPagedResponse> EditDocumentStoreFileChunkAsync(
            string storeId,
            string loaderId,
            string chunkId,

            global::Flowise.Document request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a specific chunk<br/>
        /// Updates a specific chunk from a document loader
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="chunkId"></param>
        /// <param name="pageContent">
        /// Example: This is the content of the page.
        /// </param>
        /// <param name="metadata">
        /// Example: {"author":"John Doe","date":"2024-08-24"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.DocumentStoreFileChunkPagedResponse> EditDocumentStoreFileChunkAsync(
            string storeId,
            string loaderId,
            string chunkId,
            string? pageContent = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}