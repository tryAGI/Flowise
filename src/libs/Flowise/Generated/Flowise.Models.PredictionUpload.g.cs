
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionUpload
    {
        /// <summary>
        /// The type of file upload<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Flowise.JsonConverters.PredictionUploadTypeJsonConverter))]
        public global::Flowise.PredictionUploadType? Type { get; set; }

        /// <summary>
        /// The name of the file or resource<br/>
        /// Example: image.png
        /// </summary>
        /// <example>image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The base64-encoded data or URL for the resource<br/>
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The MIME type of the file or resource<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Flowise.JsonConverters.PredictionUploadMimeJsonConverter))]
        public global::Flowise.PredictionUploadMime? Mime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUpload" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of file upload<br/>
        /// Example: file
        /// </param>
        /// <param name="name">
        /// The name of the file or resource<br/>
        /// Example: image.png
        /// </param>
        /// <param name="data">
        /// The base64-encoded data or URL for the resource<br/>
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </param>
        /// <param name="mime">
        /// The MIME type of the file or resource<br/>
        /// Example: image/png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionUpload(
            global::Flowise.PredictionUploadType? type,
            string? name,
            string? data,
            global::Flowise.PredictionUploadMime? mime)
        {
            this.Type = type;
            this.Name = name;
            this.Data = data;
            this.Mime = mime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUpload" /> class.
        /// </summary>
        public PredictionUpload()
        {
        }
    }
}