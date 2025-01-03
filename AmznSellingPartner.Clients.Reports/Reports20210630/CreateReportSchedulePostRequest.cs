namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/reports/2021-06-30/schedules")]
	public class CreateReportSchedulePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Information required to create the report schedule.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateReportScheduleSpecification Body { get; set; }
	}
}
