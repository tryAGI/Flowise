#nullable enable

namespace Flowise
{
    public partial interface IUpsertHistoryClient
    {
        /// <summary>
        /// Get all upsert history records<br/>
        /// Retrieve all upsert history records with optional filters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order">
        /// Default Value: ASC
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.UpsertHistoryResponse>> GetAllUpsertHistoryAsync(
            string id,
            global::Flowise.GetAllUpsertHistoryOrder? order = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}