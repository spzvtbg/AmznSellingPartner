namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/finances/transfers/2024-06-01/payouts")]
	public class InitiatePayoutPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `initiatePayout` operation
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public InitiatePayoutRequest Body { get; set; }
	}
}
