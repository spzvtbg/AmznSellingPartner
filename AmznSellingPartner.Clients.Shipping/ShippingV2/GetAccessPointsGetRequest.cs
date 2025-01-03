namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/shipping/v2/accessPoints")]
	public class GetAccessPointsGetRequest : BaseHttpRequest
	{
		[InQuery("accessPointTypes")]
		[IsRequired]
		[JsonProperty("accessPointTypes")]
		public CsvValue<AccessPointTypes> AccessPointTypes { get; set; }

		[InQuery("countryCode")]
		[IsRequired]
		[JsonProperty("countryCode")]
		public CsvValue<string> CountryCode { get; set; }

		[InQuery("postalCode")]
		[IsRequired]
		[JsonProperty("postalCode")]
		public CsvValue<string> PostalCode { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
