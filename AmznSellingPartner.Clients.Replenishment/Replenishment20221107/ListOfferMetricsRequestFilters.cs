namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Use these parameters to filter results. Any result must match all provided parameters. For any parameter
	/// that is an array, the result must match at least one element in the provided array.
	/// </summary>
	public class ListOfferMetricsRequestFilters : BaseClass
	{
		[JsonProperty("aggregationFrequency")]
		public AggregationFrequency AggregationFrequency { get; set; }

		/// <summary>
		/// A time interval used to compute metrics.
		/// </summary>
		[JsonProperty("timeInterval")]
		[IsRequired]
		public TimeInterval TimeInterval { get; set; }

		[JsonProperty("timePeriodType")]
		[IsRequired]
		public TimePeriodType TimePeriodType { get; set; }

		/// <summary>
		/// The marketplace identifier. The supported marketplaces for both sellers and vendors are US, CA, ES, UK,
		/// FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU, MX, AE and NL.  Refer
		/// to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids) to find the identifier
		/// for the marketplace.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; }

		[JsonProperty("programTypes")]
		[IsRequired]
		public ProgramTypes ProgramTypes { get; set; }

		/// <summary>
		/// A list of Amazon Standard Identification Numbers (ASINs).
		/// </summary>
		[JsonProperty("asins")]
		[MinItems(1)]
		[MaxItems(20)]
		[UniqueItems]
		public List<string> Asins { get; set; }
	}
}
