
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
        Internal,
        /// <summary>
        /// 
        /// </summary>
        External,
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
                RemoveAllChatMessagesChatType.Internal => "INTERNAL",
                RemoveAllChatMessagesChatType.External => "EXTERNAL",
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
                "INTERNAL" => RemoveAllChatMessagesChatType.Internal,
                "EXTERNAL" => RemoveAllChatMessagesChatType.External,
                _ => null,
            };
        }
    }
}