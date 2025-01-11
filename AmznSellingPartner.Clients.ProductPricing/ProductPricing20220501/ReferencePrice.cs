namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The reference price for the specified ASIN `marketplaceId` combination.
	/// </summary>
	public class ReferencePrice : BaseClass
	{
		/// <summary>
		/// The name of the reference price, such as `CompetitivePriceThreshold` and `WasPrice`. For reference
		/// price definitions, refer to the [Use Case Guide](https://developer-docs.amazon.com/sp-api/
		/// docs/product-pricing-api-v2022-05-01-use-case-guide).
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		public string Name { get; set; } 

		/// <summary>
		/// The reference price for the ASIN `marketplaceId` combination.
		/// </summary>
		[JsonProperty("price")]
		[IsRequired]
		public MoneyType Price { get; set; } 
	}
}
