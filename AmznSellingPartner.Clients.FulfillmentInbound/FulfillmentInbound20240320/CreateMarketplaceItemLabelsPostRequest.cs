namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/inbound/fba/2024-03-20/items/labels")]
	public class CreateMarketplaceItemLabelsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The body of the request to `createMarketplaceItemLabels`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateMarketplaceItemLabelsRequest Body { get; set; }
	}
}
