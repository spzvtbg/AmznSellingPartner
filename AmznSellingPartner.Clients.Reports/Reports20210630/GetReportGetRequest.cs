namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/reports/2021-06-30/reports/{reportId}")]
	public class GetReportGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the report. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[InPath("reportId")]
		[IsRequired]
		public string ReportId { get; set; } 
	}
}
