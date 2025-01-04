namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/shipping/v2/shipments/rates")]
	public class GetRatesPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetRatesRequest Body { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
