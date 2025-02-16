namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class SearchContentDocumentsResponse : BaseClass
    {
        /// <summary>
        /// The content metadata records.
        /// </summary>
        [JsonProperty("contentMetadataRecords")]
        [IsRequired]
        public ContentMetadataRecordList ContentMetadataRecords { get; set; }
    }
}
