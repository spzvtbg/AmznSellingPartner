namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information about an SKU, including the count available, identifiers, and a list of overlapping SKUs
	/// that share the same inventory pool.
	/// </summary>
	public class FeatureSku : BaseClass
	{
		/// <summary>
		/// Used to identify an item in the given marketplace. `SellerSKU` is qualified by the seller's SellerId,
		/// which is included with every operation that you submit.
		/// </summary>
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The unique SKU used by Amazon's fulfillment network.
		/// </summary>
		[JsonProperty("fnSku")]
		public string FnSku { get; set; }

		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The number of SKUs available for this service.
		/// </summary>
		[JsonProperty("skuCount")]
		public double SkuCount { get; set; }

		/// <summary>
		/// Other seller SKUs that are shared across the same inventory.
		/// </summary>
		[JsonProperty("overlappingSkus")]
		public List<string> OverlappingSkus { get; set; }
	}
}
