#nullable enable

namespace Flowise.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAllChatMessagesOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Flowise.GetAllChatMessagesOrder?>
    {
        /// <inheritdoc />
        public override global::Flowise.GetAllChatMessagesOrder? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Flowise.GetAllChatMessagesOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Flowise.GetAllChatMessagesOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Flowise.GetAllChatMessagesOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Flowise.GetAllChatMessagesOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Flowise.GetAllChatMessagesOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
