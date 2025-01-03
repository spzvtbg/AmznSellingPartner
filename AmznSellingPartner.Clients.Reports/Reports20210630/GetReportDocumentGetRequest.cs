namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/reports/2021-06-30/documents/{reportDocumentId}")]
	public class GetReportDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the report document
		/// </summary>
		[InPath("reportDocumentId")]
		[IsRequired]
		[JsonProperty("reportDocumentId")]
		public string ReportDocumentId { get; set; }
	}
}
