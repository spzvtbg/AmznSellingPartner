namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class SearchContentPublishRecordsResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("publishRecordList")]
		public PublishRecordList PublishRecordList { get; set; }
	}
}
