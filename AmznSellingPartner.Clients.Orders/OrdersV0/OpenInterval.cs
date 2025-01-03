namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The time interval for which the business is open.
	/// </summary>
	public class OpenInterval : BaseClass
	{
		/// <summary>
		/// The time when the business opens.
		/// </summary>
		[JsonProperty("StartTime")]
		public OpenTimeInterval StartTime { get; set; }

		/// <summary>
		/// The time when the business closes.
		/// </summary>
		[JsonProperty("EndTime")]
		public OpenTimeInterval EndTime { get; set; }
	}
}
