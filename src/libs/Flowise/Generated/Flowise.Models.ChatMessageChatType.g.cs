
#nullable enable

namespace Flowise
{
    /// <summary>
    /// Example: INTERNAL
    /// </summary>
    public enum ChatMessageChatType
    {
        /// <summary>
        /// 
        /// </summary>
        INTERNAL,
        /// <summary>
        /// 
        /// </summary>
        EXTERNAL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageChatType value)
        {
            return value switch
            {
                ChatMessageChatType.INTERNAL => "INTERNAL",
                ChatMessageChatType.EXTERNAL => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageChatType? ToEnum(string value)
        {
            return value switch
            {
                "INTERNAL" => ChatMessageChatType.INTERNAL,
                "EXTERNAL" => ChatMessageChatType.EXTERNAL,
                _ => null,
            };
        }
    }
}