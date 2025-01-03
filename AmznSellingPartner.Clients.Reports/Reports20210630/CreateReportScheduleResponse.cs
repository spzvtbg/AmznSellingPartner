namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Response schema
	/// </summary>
	public class CreateReportScheduleResponse : BaseClass
	{
		/// <summary>
		/// The identifier for the report schedule
		/// This identifier is unique only in combination with a seller ID
		/// </summary>
		[IsRequired]
		[JsonProperty("reportScheduleId")]
		public string ReportScheduleId { get; set; }
	}
}
