
#nullable enable

namespace Flowise
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForRefresh
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Flowise.DocumentStoreLoaderForUpsert>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForRefresh" /> class.
        /// </summary>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStoreLoaderForRefresh(
            global::System.Collections.Generic.IList<global::Flowise.DocumentStoreLoaderForUpsert>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForRefresh" /> class.
        /// </summary>
        public DocumentStoreLoaderForRefresh()
        {
        }
    }
}