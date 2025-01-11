namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information required to create the report.
	/// </summary>
	public class CreateReportSpecification : BaseClass
	{
		[JsonProperty("reportOptions")]
		public ReportOptions ReportOptions { get; set; } 

		/// <summary>
		/// The report type. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
		/// for more information.
		/// </summary>
		[JsonProperty("reportType")]
		[IsRequired]
		public string ReportType { get; set; } 

		/// <summary>
		/// The start of a date and time range, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format, used for selecting the data to report. The default is now. The value
		/// must be prior to or equal to the current date and time. Not all report types make use of t
		/// his.
		/// </summary>
		[JsonProperty("dataStartTime")]
		public DateTimeValue DataStartTime { get; set; } 

		/// <summary>
		/// The end of a date and time range, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format, used for selecting the data to report. The default is now. The value
		/// must be prior to or equal to the current date and time. Not all report types make use of t
		/// his.
		/// </summary>
		[JsonProperty("dataEndTime")]
		public DateTimeValue DataEndTime { get; set; } 

		/// <summary>
		/// A list of marketplace identifiers. The report document's contents will contain data for all
		/// of the specified marketplaces, unless the report type indicates otherwise.
		/// </summary>
		[JsonProperty("marketplaceIds")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(25)]
		public List<string> MarketplaceIds { get; set; } 
	}
}
