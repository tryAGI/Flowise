
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChatMessagesFeedbackType
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
    public static class GetAllChatMessagesFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesFeedbackType value)
        {
            return value switch
            {
                GetAllChatMessagesFeedbackType.ThumbsUp => "THUMBS_UP",
                GetAllChatMessagesFeedbackType.ThumbsDown => "THUMBS_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "THUMBS_UP" => GetAllChatMessagesFeedbackType.ThumbsUp,
                "THUMBS_DOWN" => GetAllChatMessagesFeedbackType.ThumbsDown,
                _ => null,
            };
        }
    }
}