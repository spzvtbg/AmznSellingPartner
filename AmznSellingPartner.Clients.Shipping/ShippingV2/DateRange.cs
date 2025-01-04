namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Date Range for query the results.
	/// </summary>
	public class DateRange : BaseClass
	{
		/// <summary>
		/// Start Date for query .
		/// </summary>
		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; } 

		/// <summary>
		/// end date for query.
		/// </summary>
		[JsonProperty("endDate")]
		public DateTime EndDate { get; set; } 
	}
}
