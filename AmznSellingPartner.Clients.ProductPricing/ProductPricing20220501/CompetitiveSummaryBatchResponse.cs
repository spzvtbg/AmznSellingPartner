namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `competitiveSummaryBatch` operation.
	/// </summary>
	public class CompetitiveSummaryBatchResponse : BaseClass
	{
		/// <summary>
		/// The response list for the `competitiveSummaryBatch` operation.
		/// </summary>
		[JsonProperty("responses")]
		[IsRequired]
		public CompetitiveSummaryResponseList Responses { get; set; } 
	}
}
