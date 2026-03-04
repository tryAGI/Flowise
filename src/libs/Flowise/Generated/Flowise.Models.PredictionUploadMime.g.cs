
#nullable enable

namespace Flowise
{
    /// <summary>
    /// The MIME type of the file or resource<br/>
    /// Example: image/png
    /// </summary>
    public enum PredictionUploadMime
    {
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
        /// <summary>
        /// 
        /// </summary>
        AudioMp4,
        /// <summary>
        /// 
        /// </summary>
        AudioWebm,
        /// <summary>
        /// 
        /// </summary>
        AudioWav,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        AudioAac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionUploadMimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionUploadMime value)
        {
            return value switch
            {
                PredictionUploadMime.ImagePng => "image/png",
                PredictionUploadMime.ImageJpeg => "image/jpeg",
                PredictionUploadMime.ImageJpg => "image/jpg",
                PredictionUploadMime.ImageGif => "image/gif",
                PredictionUploadMime.ImageWebp => "image/webp",
                PredictionUploadMime.AudioMp4 => "audio/mp4",
                PredictionUploadMime.AudioWebm => "audio/webm",
                PredictionUploadMime.AudioWav => "audio/wav",
                PredictionUploadMime.AudioMpeg => "audio/mpeg",
                PredictionUploadMime.AudioOgg => "audio/ogg",
                PredictionUploadMime.AudioAac => "audio/aac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionUploadMime? ToEnum(string value)
        {
            return value switch
            {
                "image/png" => PredictionUploadMime.ImagePng,
                "image/jpeg" => PredictionUploadMime.ImageJpeg,
                "image/jpg" => PredictionUploadMime.ImageJpg,
                "image/gif" => PredictionUploadMime.ImageGif,
                "image/webp" => PredictionUploadMime.ImageWebp,
                "audio/mp4" => PredictionUploadMime.AudioMp4,
                "audio/webm" => PredictionUploadMime.AudioWebm,
                "audio/wav" => PredictionUploadMime.AudioWav,
                "audio/mpeg" => PredictionUploadMime.AudioMpeg,
                "audio/ogg" => PredictionUploadMime.AudioOgg,
                "audio/aac" => PredictionUploadMime.AudioAac,
                _ => null,
            };
        }
    }
}