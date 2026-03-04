
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
    public static class DocumentStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreStatus value)
        {
            return value switch
            {
                DocumentStoreStatus.EMPTY => "EMPTY",
                DocumentStoreStatus.SYNC => "SYNC",
                DocumentStoreStatus.SYNCING => "SYNCING",
                DocumentStoreStatus.STALE => "STALE",
                DocumentStoreStatus.NEW => "NEW",
                DocumentStoreStatus.UPSERTING => "UPSERTING",
                DocumentStoreStatus.UPSERTED => "UPSERTED",
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
                "EMPTY" => DocumentStoreStatus.EMPTY,
                "SYNC" => DocumentStoreStatus.SYNC,
                "SYNCING" => DocumentStoreStatus.SYNCING,
                "STALE" => DocumentStoreStatus.STALE,
                "NEW" => DocumentStoreStatus.NEW,
                "UPSERTING" => DocumentStoreStatus.UPSERTING,
                "UPSERTED" => DocumentStoreStatus.UPSERTED,
                _ => null,
            };
        }
    }
}