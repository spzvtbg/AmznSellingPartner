namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body for the `getSellingPartnerMetrics` operation.
	/// </summary>
	public class GetSellingPartnerMetricsRequest : BaseClass
	{
		[JsonProperty("aggregationFrequency")]
		public AggregationFrequency AggregationFrequency { get; set; }

		/// <summary>
		/// A time interval used to compute metrics.
		/// </summary>
		[JsonProperty("timeInterval")]
		[IsRequired]
		public TimeInterval TimeInterval { get; set; }

		/// <summary>
		/// The list of metrics requested. If no metric value is provided, data for all of the metrics will be r
		/// eturned.
		/// </summary>
		[JsonProperty("metrics")]
		[MinItems(1)]
		[UniqueItems]
		public List<Metric> Metrics { get; set; }

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

		/// <summary>
		/// The list of replenishment program types for which to return metrics.
		/// </summary>
		[JsonProperty("programTypes")]
		[IsRequired]
		public ProgramTypes ProgramTypes { get; set; }
	}
}
