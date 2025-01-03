namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema
	/// </summary>
	public class GetMyFeesEstimateResult : BaseClass
	{
		/// <summary>
		/// The item's estimated fees
		/// </summary>
		[JsonProperty("FeesEstimateResult")]
		public FeesEstimateResult FeesEstimateResult { get; set; }
	}
}
