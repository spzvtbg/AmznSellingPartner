namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response schema.
	/// </summary>
	public class CreateReportResponse : BaseClass
	{
		/// <summary>
		/// The identifier for the report. This identifier is unique only in combination with a seller ID.
		/// </summary>
		[JsonProperty("reportId")]
		[IsRequired]
		public string ReportId { get; set; }
	}
}
