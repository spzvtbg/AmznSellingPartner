namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/shipping/v2/tracking")]
	public class GetTrackingGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A carrier-generated tracking identifier originally returned by the purchaseShipment operation.
		/// </summary>
		[InQuery("trackingId")]
		[IsRequired]
		[JsonProperty("trackingId")]
		public string TrackingId { get; set; }

		/// <summary>
		/// A carrier identifier originally returned by the getRates operation for the selected rate.
		/// </summary>
		[InQuery("carrierId")]
		[IsRequired]
		[JsonProperty("carrierId")]
		public string CarrierId { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
