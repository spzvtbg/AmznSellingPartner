namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/reports/2021-06-30/schedules")]
	public class GetReportSchedulesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of report types used to filter report schedules. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
		/// for more information.
		/// </summary>
		[InQuery("reportTypes")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(10)]
		[JsonProperty("reportTypes")]
		public CsvValue<string> ReportTypes { get; set; }
	}
}
