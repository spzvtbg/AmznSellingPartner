namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	public class GetMyFeesEstimateResponse : BaseClass
	{
		/// <summary>
		/// The payload for the operation
		/// </summary>
		[JsonProperty("payload")]
		public GetMyFeesEstimateResult Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
