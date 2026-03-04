#nullable enable

namespace Flowise
{
    public partial interface ILeadsClient
    {
        /// <summary>
        /// Get all leads for a specific chatflow<br/>
        /// Retrieve all leads associated with a specific chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.Lead>> GetAllLeadsForChatflowAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}