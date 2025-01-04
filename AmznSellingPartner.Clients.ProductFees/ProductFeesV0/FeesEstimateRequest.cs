namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A product, marketplace, and proposed price used to request estimated fees.
	/// </summary>
	public class FeesEstimateRequest : BaseClass
	{
		/// <summary>
		/// A marketplace identifier.
		/// </summary>
		[JsonProperty("MarketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// When true, the offer is fulfilled by Amazon.
		/// </summary>
		[JsonProperty("IsAmazonFulfilled")]
		public bool IsAmazonFulfilled { get; set; } 

		/// <summary>
		/// The product price that the fee estimate is based on.
		/// </summary>
		[JsonProperty("PriceToEstimateFees")]
		[IsRequired]
		public PriceToEstimateFees PriceToEstimateFees { get; set; } 

		/// <summary>
		/// A unique identifier provided by the caller to track this request.
		/// </summary>
		[JsonProperty("Identifier")]
		[IsRequired]
		public string Identifier { get; set; } 

		[JsonProperty("OptionalFulfillmentProgram")]
		public OptionalFulfillmentProgram OptionalFulfillmentProgram { get; set; } 
	}
}
