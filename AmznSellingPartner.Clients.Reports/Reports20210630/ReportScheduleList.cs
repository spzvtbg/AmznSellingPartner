namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of report schedules.
	/// </summary>
	public class ReportScheduleList : BaseClass
	{
		/// <summary>
		/// Detailed information about a report schedule.
		/// </summary>
		[JsonProperty("reportSchedules")]
		[IsRequired]
		public List<ReportSchedule> ReportSchedules { get; set; }
	}
}
