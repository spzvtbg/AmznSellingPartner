namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class SearchContentPublishRecordsResponse : BaseClass
	{
		[JsonProperty("publishRecordList")]
		[IsRequired]
		public PublishRecordList PublishRecordList { get; set; } 
	}
}
