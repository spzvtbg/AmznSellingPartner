namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `competitiveSummary` batch request data
	/// </summary>
	public class CompetitiveSummaryBatchRequest : BaseClass
	{
		/// <summary>
		/// A batched list of `competitiveSummary` requests
		/// </summary>
		[IsRequired]
		[JsonProperty("requests")]
		public CompetitiveSummaryRequestList Requests { get; set; }
	}
}
