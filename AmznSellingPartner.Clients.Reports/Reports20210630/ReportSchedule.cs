namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Detailed information about a report schedule.
	/// </summary>
	public class ReportSchedule : BaseClass
	{
		/// <summary>
		/// The identifier for the report schedule. This identifier is unique only in combination with a seller
		/// ID.
		/// </summary>
		[JsonProperty("reportScheduleId")]
		[IsRequired]
		public string ReportScheduleId { get; set; } 

		/// <summary>
		/// The report type. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
		/// for more information.
		/// </summary>
		[JsonProperty("reportType")]
		[IsRequired]
		public string ReportType { get; set; } 

		/// <summary>
		/// A list of marketplace identifiers. The report document's contents will contain data for all of the specified
		/// marketplaces, unless the report type indicates otherwise.
		/// </summary>
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; } 

		[JsonProperty("reportOptions")]
		public ReportOptions ReportOptions { get; set; } 

		/// <summary>
		/// An <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> period value that indicates
		/// how often a report should be created.
		/// </summary>
		[JsonProperty("period")]
		[IsRequired]
		public string Period { get; set; } 

		/// <summary>
		/// The date and time when the schedule will create its next report, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format.
		/// </summary>
		[JsonProperty("nextReportCreationTime")]
		public DateTimeValue NextReportCreationTime { get; set; } 
	}
}
