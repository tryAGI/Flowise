
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
        Empty,
        /// <summary>
        /// 
        /// </summary>
        Sync,
        /// <summary>
        /// 
        /// </summary>
        Syncing,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Upserting,
        /// <summary>
        /// 
        /// </summary>
        Upserted,
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
                DocumentStoreLoaderForPreviewStatus.Empty => "EMPTY",
                DocumentStoreLoaderForPreviewStatus.Sync => "SYNC",
                DocumentStoreLoaderForPreviewStatus.Syncing => "SYNCING",
                DocumentStoreLoaderForPreviewStatus.Stale => "STALE",
                DocumentStoreLoaderForPreviewStatus.New => "NEW",
                DocumentStoreLoaderForPreviewStatus.Upserting => "UPSERTING",
                DocumentStoreLoaderForPreviewStatus.Upserted => "UPSERTED",
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
                "EMPTY" => DocumentStoreLoaderForPreviewStatus.Empty,
                "SYNC" => DocumentStoreLoaderForPreviewStatus.Sync,
                "SYNCING" => DocumentStoreLoaderForPreviewStatus.Syncing,
                "STALE" => DocumentStoreLoaderForPreviewStatus.Stale,
                "NEW" => DocumentStoreLoaderForPreviewStatus.New,
                "UPSERTING" => DocumentStoreLoaderForPreviewStatus.Upserting,
                "UPSERTED" => DocumentStoreLoaderForPreviewStatus.Upserted,
                _ => null,
            };
        }
    }
}