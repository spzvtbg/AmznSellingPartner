namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using System;

	[HttpGet("/reports/2021-06-30/reports")]
	public class GetReportsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of report types used to filter reports. Refer to [Report Type Values](https://developer-docs.amazon.com/sp-api/docs/report-type-values)
		/// for more information. When reportTypes is provided, the other filter parameters (processingStatuses,
		/// marketplaceIds, createdSince, createdUntil) and pageSize may also be provided. Either reportTypes or
		/// nextToken is required.
		/// </summary>
		[InQuery("reportTypes")]
		[MinItems(1)]
		[MaxItems(10)]
		public CsvValue<string> ReportTypes { get; set; }

		/// <summary>
		/// A list of processing statuses used to filter reports.
		/// </summary>
		[InQuery("processingStatuses")]
		[MinItems(1)]
		public CsvValue<ProcessingStatuses> ProcessingStatuses { get; set; }

		/// <summary>
		/// A list of marketplace identifiers used to filter reports. The reports returned will match at least one
		/// of the marketplaces that you specify.
		/// </summary>
		[InQuery("marketplaceIds")]
		[MinItems(1)]
		[MaxItems(10)]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The maximum number of reports to return in a single call.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(100)]
		public int PageSize { get; set; }

		/// <summary>
		/// The earliest report creation date and time for reports to include in the response, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format. The default is 90 days ago. Reports are retained for a maximum of 90 days
		/// .
		/// </summary>
		[InQuery("createdSince")]
		public DateTime CreatedSince { get; set; }

		/// <summary>
		/// The latest report creation date and time for reports to include in the response, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> date time format. The default is now.
		/// </summary>
		[InQuery("createdUntil")]
		public DateTime CreatedUntil { get; set; }

		/// <summary>
		/// A string token returned in the response to your previous request. `nextToken` is returned when the number
		/// of results exceeds the specified `pageSize` value. To get the next page of results, call the `getReports`
		/// operation and include this token as the only parameter. Specifying `nextToken` with any other parameters
		/// will cause the request to fail.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; }
	}
}
