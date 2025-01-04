namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The common properties for individual requests within a batch.
	/// </summary>
	public class BatchRequest : BaseClass
	{
		/// <summary>
		/// The URI associated with an individual request within a batch. For `FeaturedOfferExpectedPrice`, this
		/// is `/products/pricing/2022-05-01/offer/featuredOfferExpectedPrice`.
		/// </summary>
		[JsonProperty("uri")]
		[IsRequired]
		public string Uri { get; set; } 

		[JsonProperty("method")]
		[IsRequired]
		public HttpMethod Method { get; set; } 

		[JsonProperty("body")]
		public HttpBody Body { get; set; } 

		[JsonProperty("headers")]
		public HttpHeaders Headers { get; set; } 
	}
}
