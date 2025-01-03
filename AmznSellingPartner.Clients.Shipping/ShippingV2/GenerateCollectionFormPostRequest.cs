namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/shipping/v2/collectionForms")]
	public class GenerateCollectionFormPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GenerateCollectionFormRequest Body { get; set; }

		/// <summary>
		/// A unique value which the server uses to recognize subsequent retries of the same request.
		/// </summary>
		[InHeader("x-amzn-IdempotencyKey")]
		[JsonProperty("x-amzn-IdempotencyKey")]
		public string XAmznIdempotencyKey { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
