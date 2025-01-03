namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getOrderMetrics operation
	/// </summary>
	public class GetOrderMetricsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the getOrderMetrics operation
		/// </summary>
		[JsonProperty("payload")]
		public OrderMetricsList Payload { get; set; }

		/// <summary>
		/// Encountered errors for the getOrderMetrics operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
