#nullable enable

namespace Flowise
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Retrieval query<br/>
        /// Retrieval query for the upserted chunks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.QueryVectorStoreResponse> QueryVectorStoreAsync(

            global::Flowise.QueryVectorStoreRequest request,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieval query<br/>
        /// Retrieval query for the upserted chunks
        /// </summary>
        /// <param name="storeId">
        /// Document Store ID<br/>
        /// Example: 603a7b51-ae7c-4b0a-8865-e454ed2f6766
        /// </param>
        /// <param name="query">
        /// Query to search for<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.QueryVectorStoreResponse> QueryVectorStoreAsync(
            string storeId,
            string query,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}