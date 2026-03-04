
#nullable enable

namespace Flowise
{
    /// <summary>
    /// Status of the file
    /// </summary>
    public enum DocumentStoreLoaderFileStatus
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
    public static class DocumentStoreLoaderFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreLoaderFileStatus value)
        {
            return value switch
            {
                DocumentStoreLoaderFileStatus.EMPTY => "EMPTY",
                DocumentStoreLoaderFileStatus.SYNC => "SYNC",
                DocumentStoreLoaderFileStatus.SYNCING => "SYNCING",
                DocumentStoreLoaderFileStatus.STALE => "STALE",
                DocumentStoreLoaderFileStatus.NEW => "NEW",
                DocumentStoreLoaderFileStatus.UPSERTING => "UPSERTING",
                DocumentStoreLoaderFileStatus.UPSERTED => "UPSERTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreLoaderFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreLoaderFileStatus.EMPTY,
                "SYNC" => DocumentStoreLoaderFileStatus.SYNC,
                "SYNCING" => DocumentStoreLoaderFileStatus.SYNCING,
                "STALE" => DocumentStoreLoaderFileStatus.STALE,
                "NEW" => DocumentStoreLoaderFileStatus.NEW,
                "UPSERTING" => DocumentStoreLoaderFileStatus.UPSERTING,
                "UPSERTED" => DocumentStoreLoaderFileStatus.UPSERTED,
                _ => null,
            };
        }
    }
}