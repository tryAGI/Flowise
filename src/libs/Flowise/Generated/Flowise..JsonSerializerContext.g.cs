
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Flowise.JsonConverters.ChatMessageRoleJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatMessageRoleNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatMessageChatTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatMessageChatTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatflowTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatflowTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionHistoryItemRoleJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionHistoryItemRoleNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionUploadTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionUploadTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionUploadMimeJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionUploadMimeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionHumanInputTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.PredictionHumanInputTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreStatusJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreStatusNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreLoaderForPreviewStatusJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreLoaderForPreviewStatusNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreLoaderFileStatusJsonConverter),
            typeof(global::Flowise.JsonConverters.DocumentStoreLoaderFileStatusNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatMessageFeedbackRatingJsonConverter),
            typeof(global::Flowise.JsonConverters.ChatMessageFeedbackRatingNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesChatTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesChatTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesOrderJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesOrderNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesFeedbackTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessagesFeedbackTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.RemoveAllChatMessagesChatTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.RemoveAllChatMessagesChatTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.RemoveAllChatMessagesFeedbackTypeJsonConverter),
            typeof(global::Flowise.JsonConverters.RemoveAllChatMessagesFeedbackTypeNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessageFeedbackSortOrderJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllChatMessageFeedbackSortOrderNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllUpsertHistoryOrderJsonConverter),
            typeof(global::Flowise.JsonConverters.GetAllUpsertHistoryOrderNullableJsonConverter),
            typeof(global::Flowise.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}