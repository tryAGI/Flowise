
#nullable enable

namespace Flowise
{
    /// <summary>
    /// Rating for the message
    /// </summary>
    public enum ChatMessageFeedbackRating
    {
        /// <summary>
        /// 
        /// </summary>
        THUMBSUP,
        /// <summary>
        /// 
        /// </summary>
        THUMBSDOWN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageFeedbackRatingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageFeedbackRating value)
        {
            return value switch
            {
                ChatMessageFeedbackRating.THUMBSUP => "THUMBS_UP",
                ChatMessageFeedbackRating.THUMBSDOWN => "THUMBS_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageFeedbackRating? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_UP" => ChatMessageFeedbackRating.THUMBSUP,
                "THUMBS_DOWN" => ChatMessageFeedbackRating.THUMBSDOWN,
                _ => null,
            };
        }
    }
}