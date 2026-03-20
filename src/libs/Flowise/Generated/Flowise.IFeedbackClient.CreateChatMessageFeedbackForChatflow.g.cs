#nullable enable

namespace Flowise
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create new chat message feedback<br/>
        /// Create new feedback for a specific chat flow.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.ChatMessageFeedback> CreateChatMessageFeedbackForChatflowAsync(

            global::Flowise.ChatMessageFeedback request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new chat message feedback<br/>
        /// Create new feedback for a specific chat flow.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the feedback
        /// </param>
        /// <param name="chatflowid">
        /// Identifier for the chat flow
        /// </param>
        /// <param name="chatId">
        /// Identifier for the chat
        /// </param>
        /// <param name="messageId">
        /// Identifier for the message
        /// </param>
        /// <param name="rating">
        /// Rating for the message
        /// </param>
        /// <param name="content">
        /// Feedback content
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the feedback was created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Flowise.ChatMessageFeedback> CreateChatMessageFeedbackForChatflowAsync(
            global::System.Guid? id = default,
            global::System.Guid? chatflowid = default,
            string? chatId = default,
            global::System.Guid? messageId = default,
            global::Flowise.ChatMessageFeedbackRating? rating = default,
            string? content = default,
            global::System.DateTime? createdDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}