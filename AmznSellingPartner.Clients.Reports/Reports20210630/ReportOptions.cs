namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional information passed to reports. This varies by report type.
	/// </summary>
	public class ReportOptions : BaseClass
	{
		[JsonProperty("")]
		public string AdditionalValue { get; set; }
	}
}
