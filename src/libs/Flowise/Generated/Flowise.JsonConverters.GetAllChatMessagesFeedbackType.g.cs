#nullable enable

namespace Flowise.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAllChatMessagesFeedbackTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Flowise.GetAllChatMessagesFeedbackType>
    {
        /// <inheritdoc />
        public override global::Flowise.GetAllChatMessagesFeedbackType Read(
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
                        return global::Flowise.GetAllChatMessagesFeedbackTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Flowise.GetAllChatMessagesFeedbackType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Flowise.GetAllChatMessagesFeedbackType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Flowise.GetAllChatMessagesFeedbackType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Flowise.GetAllChatMessagesFeedbackTypeExtensions.ToValueString(value));
        }
    }
}
