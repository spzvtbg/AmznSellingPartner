namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// An individual `competitiveSummary` request for an ASIN and `marketplaceId`.
	/// </summary>
	public class CompetitiveSummaryRequest : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number for the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("asin")]
		public Asin Asin { get; set; }

		/// <summary>
		/// A marketplace identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		/// <summary>
		/// The list of requested competitive pricing data for the product.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("includedData")]
		public List<CompetitiveSummaryIncludedData> IncludedData { get; set; }

		/// <summary>
		/// The list of `lowestPricedOffersInput` parameters that are used to build `lowestPricedOffers` in the response.
		/// his attribute is only valid if `lowestPricedOffers` is requested in `includedData`
		/// </summary>
		[MinItems(0)]
		[MaxItems(5)]
		[JsonProperty("lowestPricedOffersInputs")]
		public List<LowestPricedOffersInput> LowestPricedOffersInputs { get; set; }

		/// <summary>
		/// HTTP method type
		/// </summary>
		[IsRequired]
		[JsonProperty("method")]
		public HttpMethod Method { get; set; }

		/// <summary>
		/// The URI associated with the individual APIs that are called as part of the batch request. For `getCompetitiveS
		/// mmary`, this is `/products/pricing/2022-05-01/items/competitiveSummary`.
		/// </summary>
		[IsRequired]
		[JsonProperty("uri")]
		public HttpUri Uri { get; set; }
	}
}
