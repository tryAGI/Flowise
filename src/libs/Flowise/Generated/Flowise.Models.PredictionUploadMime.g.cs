
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
        AudioDivideaac,
        /// <summary>
        /// 
        /// </summary>
        AudioDividemp4,
        /// <summary>
        /// 
        /// </summary>
        AudioDividempeg,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideogg,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewav,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewebm,
        /// <summary>
        /// 
        /// </summary>
        ImageDividegif,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
        /// <summary>
        /// 
        /// </summary>
        ImageDividewebp,
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
                PredictionUploadMime.AudioDivideaac => "audio/aac",
                PredictionUploadMime.AudioDividemp4 => "audio/mp4",
                PredictionUploadMime.AudioDividempeg => "audio/mpeg",
                PredictionUploadMime.AudioDivideogg => "audio/ogg",
                PredictionUploadMime.AudioDividewav => "audio/wav",
                PredictionUploadMime.AudioDividewebm => "audio/webm",
                PredictionUploadMime.ImageDividegif => "image/gif",
                PredictionUploadMime.ImageDividejpeg => "image/jpeg",
                PredictionUploadMime.ImageDividejpg => "image/jpg",
                PredictionUploadMime.ImageDividepng => "image/png",
                PredictionUploadMime.ImageDividewebp => "image/webp",
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
                "audio/aac" => PredictionUploadMime.AudioDivideaac,
                "audio/mp4" => PredictionUploadMime.AudioDividemp4,
                "audio/mpeg" => PredictionUploadMime.AudioDividempeg,
                "audio/ogg" => PredictionUploadMime.AudioDivideogg,
                "audio/wav" => PredictionUploadMime.AudioDividewav,
                "audio/webm" => PredictionUploadMime.AudioDividewebm,
                "image/gif" => PredictionUploadMime.ImageDividegif,
                "image/jpeg" => PredictionUploadMime.ImageDividejpeg,
                "image/jpg" => PredictionUploadMime.ImageDividejpg,
                "image/png" => PredictionUploadMime.ImageDividepng,
                "image/webp" => PredictionUploadMime.ImageDividewebp,
                _ => null,
            };
        }
    }
}