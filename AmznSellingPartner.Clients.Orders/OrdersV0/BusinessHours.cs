namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Business days and hours when the destination is open for deliveries
	/// </summary>
	public class BusinessHours : BaseClass
	{
		/// <summary>
		/// Day of the week
		/// </summary>
		[JsonProperty("DayOfWeek")]
		public DayOfWeek DayOfWeek { get; set; }

		/// <summary>
		/// Time window during the day when the business is open
		/// </summary>
		[JsonProperty("OpenIntervals")]
		public List<OpenInterval> OpenIntervals { get; set; }
	}
}
