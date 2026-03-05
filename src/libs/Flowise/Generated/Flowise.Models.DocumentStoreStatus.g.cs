
#nullable enable

namespace Flowise
{
    /// <summary>
    /// Status of the document store
    /// </summary>
    public enum DocumentStoreStatus
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
    public static class DocumentStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreStatus value)
        {
            return value switch
            {
                DocumentStoreStatus.Empty => "EMPTY",
                DocumentStoreStatus.Sync => "SYNC",
                DocumentStoreStatus.Syncing => "SYNCING",
                DocumentStoreStatus.Stale => "STALE",
                DocumentStoreStatus.New => "NEW",
                DocumentStoreStatus.Upserting => "UPSERTING",
                DocumentStoreStatus.Upserted => "UPSERTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreStatus.Empty,
                "SYNC" => DocumentStoreStatus.Sync,
                "SYNCING" => DocumentStoreStatus.Syncing,
                "STALE" => DocumentStoreStatus.Stale,
                "NEW" => DocumentStoreStatus.New,
                "UPSERTING" => DocumentStoreStatus.Upserting,
                "UPSERTED" => DocumentStoreStatus.Upserted,
                _ => null,
            };
        }
    }
}