
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChatMessagesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        ASC,
        /// <summary>
        /// 
        /// </summary>
        DESC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChatMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesOrder value)
        {
            return value switch
            {
                GetAllChatMessagesOrder.ASC => "ASC",
                GetAllChatMessagesOrder.DESC => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetAllChatMessagesOrder.ASC,
                "DESC" => GetAllChatMessagesOrder.DESC,
                _ => null,
            };
        }
    }
}