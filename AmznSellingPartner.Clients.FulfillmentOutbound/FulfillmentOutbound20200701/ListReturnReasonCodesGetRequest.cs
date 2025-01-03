namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/fba/outbound/2020-07-01/returnReasonCodes")]
	public class ListReturnReasonCodesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The seller SKU for which return reason codes are required.
		/// </summary>
		[InQuery("sellerSku")]
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The marketplace for which the seller wants return reason codes.
		/// </summary>
		[InQuery("marketplaceId")]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The identifier assigned to the item by the seller when the fulfillment order was created. The service uses thi
		/// value to determine the marketplace for which the seller wants return reason codes.
		/// </summary>
		[InQuery("sellerFulfillmentOrderId")]
		[JsonProperty("sellerFulfillmentOrderId")]
		public string SellerFulfillmentOrderId { get; set; }

		/// <summary>
		/// The language that the `TranslatedDescription` property of the `ReasonCodeDetails` response object should be tr
		/// nslated into.
		/// </summary>
		[InQuery("language")]
		[JsonProperty("language")]
		public string Language { get; set; }
	}
}
