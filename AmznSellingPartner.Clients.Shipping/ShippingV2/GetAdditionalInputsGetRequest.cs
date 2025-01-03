namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/shipping/v2/shipments/additionalInputs/schema")]
	public class GetAdditionalInputsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request token returned in the response to the getRates operation.
		/// </summary>
		[InQuery("requestToken")]
		[IsRequired]
		[JsonProperty("requestToken")]
		public string RequestToken { get; set; }

		/// <summary>
		/// The rate identifier for the shipping offering (rate) returned in the response to the getRates operation.
		/// </summary>
		[InQuery("rateId")]
		[IsRequired]
		[JsonProperty("rateId")]
		public string RateId { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
