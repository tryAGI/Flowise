#nullable enable

namespace Flowise
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// List all chat message feedbacks for a chatflow<br/>
        /// Retrieve all feedbacks for a chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatId"></param>
        /// <param name="sortOrder">
        /// Default Value: asc
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Flowise.ChatMessageFeedback>> GetAllChatMessageFeedbackAsync(
            string id,
            string? chatId = default,
            global::Flowise.GetAllChatMessageFeedbackSortOrder? sortOrder = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}