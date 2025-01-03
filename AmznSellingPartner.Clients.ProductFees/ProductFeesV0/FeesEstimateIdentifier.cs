namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// An item identifier, marketplace, time of request, and other details that identify an estimate.
	/// </summary>
	public class FeesEstimateIdentifier : BaseClass
	{
		/// <summary>
		/// A marketplace identifier.
		/// </summary>
		[JsonProperty("MarketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The seller identifier.
		/// </summary>
		[JsonProperty("SellerId")]
		public string SellerId { get; set; }

		[JsonProperty("IdType")]
		public IdType IdType { get; set; }

		/// <summary>
		/// The item identifier.
		/// </summary>
		[JsonProperty("IdValue")]
		public string IdValue { get; set; }

		/// <summary>
		/// When true, the offer is fulfilled by Amazon.
		/// </summary>
		[JsonProperty("IsAmazonFulfilled")]
		public bool IsAmazonFulfilled { get; set; }

		/// <summary>
		/// The item price on which the fee estimate is based.
		/// </summary>
		[JsonProperty("PriceToEstimateFees")]
		public PriceToEstimateFees PriceToEstimateFees { get; set; }

		/// <summary>
		/// A unique identifier provided by the caller to track this request.
		/// </summary>
		[JsonProperty("SellerInputIdentifier")]
		public string SellerInputIdentifier { get; set; }

		[JsonProperty("OptionalFulfillmentProgram")]
		public OptionalFulfillmentProgram OptionalFulfillmentProgram { get; set; }
	}
}
