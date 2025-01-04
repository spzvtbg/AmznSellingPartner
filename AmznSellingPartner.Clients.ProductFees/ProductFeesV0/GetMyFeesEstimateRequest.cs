namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Request schema.
	/// </summary>
	public class GetMyFeesEstimateRequest : BaseClass
	{
		[JsonProperty("FeesEstimateRequest")]
		public FeesEstimateRequest FeesEstimateRequest { get; set; } 
	}
}
