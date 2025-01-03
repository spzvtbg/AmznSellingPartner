namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The time when the business opens or closes.
	/// </summary>
	public class OpenTimeInterval : BaseClass
	{
		/// <summary>
		/// The hour when the business opens or closes.
		/// </summary>
		[JsonProperty("Hour")]
		public int Hour { get; set; }

		/// <summary>
		/// The minute when the business opens or closes.
		/// </summary>
		[JsonProperty("Minute")]
		public int Minute { get; set; }
	}
}
