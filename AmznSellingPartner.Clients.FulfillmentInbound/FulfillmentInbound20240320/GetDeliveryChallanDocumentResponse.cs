namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `getDeliveryChallanDocumentResponse` response.
	/// </summary>
	public class GetDeliveryChallanDocumentResponse : BaseClass
	{
		[JsonProperty("documentDownload")]
		[IsRequired]
		public DocumentDownload DocumentDownload { get; set; } 
	}
}
