namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPut("/fba/outbound/2020-07-01/fulfillmentOrders/{sellerFulfillmentOrderId}/return")]
	public class CreateFulfillmentReturnPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// CreateFulfillmentReturnRequest parameter
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateFulfillmentReturnRequest Body { get; set; }

		/// <summary>
		/// An identifier assigned by the seller to the fulfillment order at the time it was created
		/// The seller uses their own records to find the correct `SellerFulfillmentOrderId` value based on the buyer's r
		/// quest to return items
		/// </summary>
		[InPath("sellerFulfillmentOrderId")]
		[IsRequired]
		[JsonProperty("sellerFulfillmentOrderId")]
		public string SellerFulfillmentOrderId { get; set; }
	}
}
