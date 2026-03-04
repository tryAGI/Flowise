
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChatMessagesChatType
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
    public static class GetAllChatMessagesChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesChatType value)
        {
            return value switch
            {
                GetAllChatMessagesChatType.INTERNAL => "INTERNAL",
                GetAllChatMessagesChatType.EXTERNAL => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesChatType? ToEnum(string value)
        {
            return value switch
            {
                "INTERNAL" => GetAllChatMessagesChatType.INTERNAL,
                "EXTERNAL" => GetAllChatMessagesChatType.EXTERNAL,
                _ => null,
            };
        }
    }
}