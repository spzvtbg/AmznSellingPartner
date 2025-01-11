namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpDelete("/reports/2021-06-30/reports/{reportId}")]
	public class AmznCancelReportRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the report. This identifier is unique only in combination with a seller
		/// ID.
		/// </summary>
		[InPath("reportId")]
		[IsRequired]
		public string ReportId { get; set; } 
	}
}
