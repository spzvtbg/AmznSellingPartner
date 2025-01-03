namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/reports/2021-06-30/schedules/{reportScheduleId}")]
	public class GetReportScheduleGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the report schedule. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[InPath("reportScheduleId")]
		[IsRequired]
		[JsonProperty("reportScheduleId")]
		public string ReportScheduleId { get; set; }
	}
}
