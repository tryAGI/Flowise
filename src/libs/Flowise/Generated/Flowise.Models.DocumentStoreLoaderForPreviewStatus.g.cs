
#nullable enable

namespace Flowise
{
    /// <summary>
    /// Status of the document store loader
    /// </summary>
    public enum DocumentStoreLoaderForPreviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        EMPTY,
        /// <summary>
        /// 
        /// </summary>
        SYNC,
        /// <summary>
        /// 
        /// </summary>
        SYNCING,
        /// <summary>
        /// 
        /// </summary>
        STALE,
        /// <summary>
        /// 
        /// </summary>
        NEW,
        /// <summary>
        /// 
        /// </summary>
        UPSERTING,
        /// <summary>
        /// 
        /// </summary>
        UPSERTED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStoreLoaderForPreviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreLoaderForPreviewStatus value)
        {
            return value switch
            {
                DocumentStoreLoaderForPreviewStatus.EMPTY => "EMPTY",
                DocumentStoreLoaderForPreviewStatus.SYNC => "SYNC",
                DocumentStoreLoaderForPreviewStatus.SYNCING => "SYNCING",
                DocumentStoreLoaderForPreviewStatus.STALE => "STALE",
                DocumentStoreLoaderForPreviewStatus.NEW => "NEW",
                DocumentStoreLoaderForPreviewStatus.UPSERTING => "UPSERTING",
                DocumentStoreLoaderForPreviewStatus.UPSERTED => "UPSERTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreLoaderForPreviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreLoaderForPreviewStatus.EMPTY,
                "SYNC" => DocumentStoreLoaderForPreviewStatus.SYNC,
                "SYNCING" => DocumentStoreLoaderForPreviewStatus.SYNCING,
                "STALE" => DocumentStoreLoaderForPreviewStatus.STALE,
                "NEW" => DocumentStoreLoaderForPreviewStatus.NEW,
                "UPSERTING" => DocumentStoreLoaderForPreviewStatus.UPSERTING,
                "UPSERTED" => DocumentStoreLoaderForPreviewStatus.UPSERTED,
                _ => null,
            };
        }
    }
}