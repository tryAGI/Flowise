
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.UsedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.UsedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.FileAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.FileAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.AgentReasoning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.AgentReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.FileUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.FileUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Action))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatMessageChatType), TypeInfoPropertyName = "ChatMessageChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Chatflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatflowType), TypeInfoPropertyName = "ChatflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ActionMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Assistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.AssistantDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.PredictionHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionHistoryItemRole), TypeInfoPropertyName = "PredictionHistoryItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.PredictionUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionUploadType), TypeInfoPropertyName = "PredictionUploadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionUploadMime), TypeInfoPropertyName = "PredictionUploadMime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionHumanInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PredictionHumanInputType), TypeInfoPropertyName = "PredictionHumanInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Variable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.VectorUpsertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.Lead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.UpsertHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreStatus), TypeInfoPropertyName = "DocumentStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreFileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForPreviewStatus), TypeInfoPropertyName = "DocumentStoreLoaderForPreviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.DocumentStoreLoaderFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderFileStatus), TypeInfoPropertyName = "DocumentStoreLoaderFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreFileChunkPagedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.DocumentStoreFileChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertDocStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertLoader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertSplitter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertVectorStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForUpsertRecordManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.DocumentStoreLoaderForRefresh))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.DocumentStoreLoaderForUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatMessageFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.ChatMessageFeedbackRating), TypeInfoPropertyName = "ChatMessageFeedbackRating2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreateAttachmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreateAttachmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.UpsertDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.UpsertDocumentRequestDocStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.QueryVectorStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.PatchDeleteUpsertHistoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.VectorUpsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.VectorUpsertRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.GetAllChatMessagesChatType), TypeInfoPropertyName = "GetAllChatMessagesChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.GetAllChatMessagesOrder), TypeInfoPropertyName = "GetAllChatMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.GetAllChatMessagesFeedbackType), TypeInfoPropertyName = "GetAllChatMessagesFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.RemoveAllChatMessagesChatType), TypeInfoPropertyName = "RemoveAllChatMessagesChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.RemoveAllChatMessagesFeedbackType), TypeInfoPropertyName = "RemoveAllChatMessagesFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.GetAllChatMessageFeedbackSortOrder), TypeInfoPropertyName = "GetAllChatMessageFeedbackSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.GetAllUpsertHistoryOrder), TypeInfoPropertyName = "GetAllUpsertHistoryOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.CreateAttachmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Chatflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.DocumentStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.VectorUpsertResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.QueryVectorStoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.ChatMessageFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Lead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Flowise.CreatePredictionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.UpsertHistoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Flowise.Variable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.UsedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.FileAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.AgentReasoning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.FileUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.PredictionHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.PredictionUpload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.DocumentStoreLoaderFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.DocumentStoreFileChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.DocumentStoreLoaderForUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.CreateAttachmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Chatflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.DocumentStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.VectorUpsertResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.ChatMessageFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Lead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.UpsertHistoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Flowise.Variable>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}