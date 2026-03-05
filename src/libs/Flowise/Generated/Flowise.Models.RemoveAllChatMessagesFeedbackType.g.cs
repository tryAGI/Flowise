
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveAllChatMessagesFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        ThumbsUp,
        /// <summary>
        /// 
        /// </summary>
        ThumbsDown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveAllChatMessagesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAllChatMessagesFeedbackType value)
        {
            return value switch
            {
                RemoveAllChatMessagesFeedbackType.ThumbsUp => "THUMBS_UP",
                RemoveAllChatMessagesFeedbackType.ThumbsDown => "THUMBS_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAllChatMessagesFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_UP" => RemoveAllChatMessagesFeedbackType.ThumbsUp,
                "THUMBS_DOWN" => RemoveAllChatMessagesFeedbackType.ThumbsDown,
                _ => null,
            };
        }
    }
}