namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/shipping/v2/shipments/directPurchase")]
	public class DirectPurchaseShipmentPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public DirectPurchaseRequest Body { get; set; }

		/// <summary>
		/// A unique value which the server uses to recognize subsequent retries of the same request.
		/// </summary>
		[InHeader("x-amzn-IdempotencyKey")]
		[JsonProperty("x-amzn-IdempotencyKey")]
		public string XAmznIdempotencyKey { get; set; }

		/// <summary>
		/// The IETF Language Tag. Note that this only supports the primary language subtag with one secondary language su
		/// tag (i.e. en-US, fr-CA). The secondary language subtag is almost always a regional designation. This does not
		/// upport additional subtags beyond the primary and secondary language subtags.
		/// </summary>
		[InHeader("locale")]
		[JsonProperty("locale")]
		public string Locale { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
