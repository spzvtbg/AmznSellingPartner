namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Detailed information about the report.
	/// </summary>
	public class Report : BaseClass
	{
		/// <summary>
		/// A list of marketplace identifiers for the report.
		/// </summary>
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The identifier for the report. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[JsonProperty("reportId")]
		[IsRequired]
		public string ReportId { get; set; }

		/// <summary>
		/// The report type. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
		/// for more information.
		/// </summary>
		[JsonProperty("reportType")]
		[IsRequired]
		public string ReportType { get; set; }

		/// <summary>
		/// The start of a date and time range used for selecting the data to report.
		/// </summary>
		[JsonProperty("dataStartTime")]
		public DateTime DataStartTime { get; set; }

		/// <summary>
		/// The end of a date and time range used for selecting the data to report.
		/// </summary>
		[JsonProperty("dataEndTime")]
		public DateTime DataEndTime { get; set; }

		/// <summary>
		/// The identifier of the report schedule that created this report (if any). This identifier is unique only
		/// in combination with a seller ID.
		/// </summary>
		[JsonProperty("reportScheduleId")]
		public string ReportScheduleId { get; set; }

		/// <summary>
		/// The date and time when the report was created.
		/// </summary>
		[JsonProperty("createdTime")]
		[IsRequired]
		public DateTime CreatedTime { get; set; }

		/// <summary>
		/// The processing status of the report.
		/// </summary>
		[JsonProperty("processingStatus")]
		[IsRequired]
		public ProcessingStatus ProcessingStatus { get; set; }

		/// <summary>
		/// The date and time when the report processing started, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format.
		/// </summary>
		[JsonProperty("processingStartTime")]
		public DateTime ProcessingStartTime { get; set; }

		/// <summary>
		/// The date and time when the report processing completed, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format.
		/// </summary>
		[JsonProperty("processingEndTime")]
		public DateTime ProcessingEndTime { get; set; }

		/// <summary>
		/// The identifier for the report document. Pass this into the `getReportDocument` operation to get the information
		/// you will need to retrieve the report document's contents.
		/// </summary>
		[JsonProperty("reportDocumentId")]
		public string ReportDocumentId { get; set; }
	}
}
