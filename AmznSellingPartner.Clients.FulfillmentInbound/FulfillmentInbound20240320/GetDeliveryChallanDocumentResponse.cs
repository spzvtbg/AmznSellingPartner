namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `getDeliveryChallanDocumentResponse` response
	/// </summary>
	public class GetDeliveryChallanDocumentResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("documentDownload")]
		public DocumentDownload DocumentDownload { get; set; }
	}
}
