#nullable enable

namespace Flowise
{
    public partial interface IChatmessageClient
    {
        /// <summary>
        /// Delete all chat messages<br/>
        /// Delete all chat messages for a specific chatflow.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="chatId"></param>
        /// <param name="memoryType">
        /// Example: Buffer Memory
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="chatType"></param>
        /// <param name="startDate">
        /// Example: 2025-01-01T11:28:36.000Z
        /// </param>
        /// <param name="endDate">
        /// Example: 2025-01-13T11:28:36.000Z
        /// </param>
        /// <param name="feedbackType"></param>
        /// <param name="hardDelete"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveAllChatMessagesAsync(
            string id,
            string? chatId = default,
            string? memoryType = default,
            string? sessionId = default,
            global::Flowise.RemoveAllChatMessagesChatType? chatType = default,
            string? startDate = default,
            string? endDate = default,
            global::Flowise.RemoveAllChatMessagesFeedbackType? feedbackType = default,
            bool? hardDelete = default,
            global::Flowise.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}