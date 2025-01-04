namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/reports/2021-06-30/documents/{reportDocumentId}")]
	public class GetReportDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the report document.
		/// </summary>
		[InPath("reportDocumentId")]
		[IsRequired]
		public string ReportDocumentId { get; set; }
	}
}
