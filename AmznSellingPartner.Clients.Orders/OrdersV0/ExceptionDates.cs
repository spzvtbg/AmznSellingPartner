namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Dates when the business is closed or open with a different time window.
	/// </summary>
	public class ExceptionDates : BaseClass
	{
		/// <summary>
		/// Date when the business is closed, in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601
		/// /a> date format.
		/// </summary>
		[JsonProperty("ExceptionDate")]
		public string ExceptionDate { get; set; }

		/// <summary>
		/// Boolean indicating if the business is closed or open on that date.
		/// </summary>
		[JsonProperty("IsOpen")]
		public bool IsOpen { get; set; }

		/// <summary>
		/// Time window during the day when the business is open.
		/// </summary>
		[JsonProperty("OpenIntervals")]
		public List<OpenInterval> OpenIntervals { get; set; }
	}
}
