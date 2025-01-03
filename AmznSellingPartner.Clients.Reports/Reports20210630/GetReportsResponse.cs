namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response for the `getReports` operation.
	/// </summary>
	public class GetReportsResponse : BaseClass
	{
		/// <summary>
		/// The reports.
		/// </summary>
		[IsRequired]
		[JsonProperty("reports")]
		public ReportList Reports { get; set; }

		/// <summary>
		/// Returned when the number of results exceeds `pageSize`. To get the next page of results, call `getReports` wit
		/// this token as the only parameter.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
