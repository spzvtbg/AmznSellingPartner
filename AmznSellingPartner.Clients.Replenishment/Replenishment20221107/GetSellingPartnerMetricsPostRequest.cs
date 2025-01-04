namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/replenishment/2022-11-07/sellingPartners/metrics/search")]
	public class GetSellingPartnerMetricsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `getSellingPartnerMetrics` operation.
		/// </summary>
		[InBody("body")]
		public GetSellingPartnerMetricsRequest Body { get; set; } 
	}
}
