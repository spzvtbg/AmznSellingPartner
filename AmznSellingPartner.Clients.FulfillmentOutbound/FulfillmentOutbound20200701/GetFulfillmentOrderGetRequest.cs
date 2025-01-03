namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}")]
	public class GetFulfillmentOrderGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier assigned to the item by the seller when the fulfillment order was created.
		/// </summary>
		[InPath("sellerFulfillmentOrderId")]
		[IsRequired]
		[MaxLength(40)]
		[JsonProperty("sellerFulfillmentOrderId")]
		public string SellerFulfillmentOrderId { get; set; }
	}
}
