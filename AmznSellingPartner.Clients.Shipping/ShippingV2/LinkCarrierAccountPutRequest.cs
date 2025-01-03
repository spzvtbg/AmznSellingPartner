namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPut("/shipping/v2/carrierAccounts/{carrierId}")]
	public class LinkCarrierAccountPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identifier associated with the carrier account.
		/// </summary>
		[InPath("carrierId")]
		[IsRequired]
		[JsonProperty("carrierId")]
		public string CarrierId { get; set; }

		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public LinkCarrierAccountRequest Body { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
