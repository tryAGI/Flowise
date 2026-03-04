
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
        THUMBSUP,
        /// <summary>
        /// 
        /// </summary>
        THUMBSDOWN,
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
                GetAllChatMessagesFeedbackType.THUMBSUP => "THUMBS_UP",
                GetAllChatMessagesFeedbackType.THUMBSDOWN => "THUMBS_DOWN",
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
                "THUMBS_UP" => GetAllChatMessagesFeedbackType.THUMBSUP,
                "THUMBS_DOWN" => GetAllChatMessagesFeedbackType.THUMBSDOWN,
                _ => null,
            };
        }
    }
}