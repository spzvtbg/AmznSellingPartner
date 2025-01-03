namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The response schema for the `getSellingPartnerMetrics` operation
	/// </summary>
	public class GetSellingPartnerMetricsResponse : BaseClass
	{
		/// <summary>
		/// A list of metrics data for the selling partner
		/// </summary>
		[JsonProperty("metrics")]
		public List<GetSellingPartnerMetricsResponseMetric> Metrics { get; set; }
	}
}
