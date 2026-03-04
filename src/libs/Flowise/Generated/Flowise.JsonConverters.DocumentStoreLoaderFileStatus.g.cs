#nullable enable

namespace Flowise.JsonConverters
{
    /// <inheritdoc />
    public sealed class DocumentStoreLoaderFileStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Flowise.DocumentStoreLoaderFileStatus>
    {
        /// <inheritdoc />
        public override global::Flowise.DocumentStoreLoaderFileStatus Read(
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
                        return global::Flowise.DocumentStoreLoaderFileStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Flowise.DocumentStoreLoaderFileStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Flowise.DocumentStoreLoaderFileStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Flowise.DocumentStoreLoaderFileStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Flowise.DocumentStoreLoaderFileStatusExtensions.ToValueString(value));
        }
    }
}
