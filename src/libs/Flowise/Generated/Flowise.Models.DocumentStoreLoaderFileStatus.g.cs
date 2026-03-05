
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
    public static class DocumentStoreLoaderFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreLoaderFileStatus value)
        {
            return value switch
            {
                DocumentStoreLoaderFileStatus.Empty => "EMPTY",
                DocumentStoreLoaderFileStatus.Sync => "SYNC",
                DocumentStoreLoaderFileStatus.Syncing => "SYNCING",
                DocumentStoreLoaderFileStatus.Stale => "STALE",
                DocumentStoreLoaderFileStatus.New => "NEW",
                DocumentStoreLoaderFileStatus.Upserting => "UPSERTING",
                DocumentStoreLoaderFileStatus.Upserted => "UPSERTED",
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
                "EMPTY" => DocumentStoreLoaderFileStatus.Empty,
                "SYNC" => DocumentStoreLoaderFileStatus.Sync,
                "SYNCING" => DocumentStoreLoaderFileStatus.Syncing,
                "STALE" => DocumentStoreLoaderFileStatus.Stale,
                "NEW" => DocumentStoreLoaderFileStatus.New,
                "UPSERTING" => DocumentStoreLoaderFileStatus.Upserting,
                "UPSERTED" => DocumentStoreLoaderFileStatus.Upserted,
                _ => null,
            };
        }
    }
}