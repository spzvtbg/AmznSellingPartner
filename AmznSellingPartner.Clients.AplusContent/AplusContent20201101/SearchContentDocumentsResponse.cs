namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class SearchContentDocumentsResponse : BaseClass
	{
		/// <summary>
		/// The content metadata records
		/// </summary>
		[IsRequired]
		[JsonProperty("contentMetadataRecords")]
		public ContentMetadataRecordList ContentMetadataRecords { get; set; }
	}
}
