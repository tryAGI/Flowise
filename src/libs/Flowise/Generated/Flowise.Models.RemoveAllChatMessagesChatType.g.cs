
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveAllChatMessagesChatType
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
    public static class RemoveAllChatMessagesChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAllChatMessagesChatType value)
        {
            return value switch
            {
                RemoveAllChatMessagesChatType.INTERNAL => "INTERNAL",
                RemoveAllChatMessagesChatType.EXTERNAL => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAllChatMessagesChatType? ToEnum(string value)
        {
            return value switch
            {
                "INTERNAL" => RemoveAllChatMessagesChatType.INTERNAL,
                "EXTERNAL" => RemoveAllChatMessagesChatType.EXTERNAL,
                _ => null,
            };
        }
    }
}