namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Use these parameters to filter results. Any result must match all of the provided parameters. For any
	/// parameter that is an array, the result must match at least one element in the provided array.
	/// </summary>
	public class ListOffersRequestFilters : BaseClass
	{
		/// <summary>
		/// The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK,
		/// FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer
		/// to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier
		/// for the marketplace.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; } 

		/// <summary>
		/// A list of SKUs to filter. This filter is only supported for sellers and not for vendors.
		/// </summary>
		[JsonProperty("skus")]
		[MinItems(1)]
		[MaxItems(20)]
		[UniqueItems]
		public List<string> Skus { get; set; } 

		/// <summary>
		/// A list of Amazon Standard Identification Numbers (ASINs).
		/// </summary>
		[JsonProperty("asins")]
		[MinItems(1)]
		[MaxItems(20)]
		[UniqueItems]
		public List<string> Asins { get; set; } 

		/// <summary>
		/// A list of eligibilities associated with an offer.
		/// </summary>
		[JsonProperty("eligibilities")]
		[MinItems(1)]
		[UniqueItems]
		public List<EligibilityStatus> Eligibilities { get; set; } 

		/// <summary>
		/// Offer preferences to include in the result filter criteria.
		/// </summary>
		[JsonProperty("preferences")]
		public Preference Preferences { get; set; } 

		/// <summary>
		/// Offer promotions to include in the result filter criteria.
		/// </summary>
		[JsonProperty("promotions")]
		public Promotion Promotions { get; set; } 

		[JsonProperty("programTypes")]
		[IsRequired]
		public ProgramTypes ProgramTypes { get; set; } 
	}
}
