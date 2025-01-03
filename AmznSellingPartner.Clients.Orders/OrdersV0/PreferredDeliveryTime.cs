namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The time window when the delivery is preferred
	/// </summary>
	public class PreferredDeliveryTime : BaseClass
	{
		/// <summary>
		/// Business hours when the business is open for deliveries
		/// </summary>
		[JsonProperty("BusinessHours")]
		public List<BusinessHours> BusinessHours { get; set; }

		/// <summary>
		/// Dates when the business is closed during the next 30 days
		/// </summary>
		[JsonProperty("ExceptionDates")]
		public List<ExceptionDates> ExceptionDates { get; set; }
	}
}
