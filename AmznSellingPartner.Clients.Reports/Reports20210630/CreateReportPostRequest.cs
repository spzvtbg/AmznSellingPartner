namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/reports/2021-06-30/reports")]
	public class CreateReportPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Information required to create the report.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateReportSpecification Body { get; set; } 
	}
}
