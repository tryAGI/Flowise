
#nullable enable

namespace Flowise
{
    /// <summary>
    /// The type of file upload<br/>
    /// Example: file
    /// </summary>
    public enum PredictionUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        File_rag,
        /// <summary>
        /// 
        /// </summary>
        File_full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionUploadType value)
        {
            return value switch
            {
                PredictionUploadType.Audio => "audio",
                PredictionUploadType.Url => "url",
                PredictionUploadType.File => "file",
                PredictionUploadType.File_rag => "file:rag",
                PredictionUploadType.File_full => "file:full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionUploadType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => PredictionUploadType.Audio,
                "url" => PredictionUploadType.Url,
                "file" => PredictionUploadType.File,
                "file:rag" => PredictionUploadType.File_rag,
                "file:full" => PredictionUploadType.File_full,
                _ => null,
            };
        }
    }
}