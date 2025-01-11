namespace AmznSellingPartner.Clients.Sales.Sales
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains order metrics.
	/// </summary>
	public class OrderMetricsInterval : BaseClass
	{
		/// <summary>
		/// The interval of time based on requested granularity (ex. Hour, Day, etc.) If this is the first
		/// or the last interval from the list, it might contain incomplete data if the requested interval
		/// doesn't align with the requested granularity (ex. request interval 2018-09-01T02:00:00Z--2018-09-04T19:00:00Z
		/// and granularity day will result in Sept 1st UTC day and Sept 4th UTC days having partial d
		/// ata).
		/// </summary>
		[JsonProperty("interval")]
		[IsRequired]
		public string Interval { get; set; } 

		/// <summary>
		/// The number of units in orders based on the specified filters.
		/// </summary>
		[JsonProperty("unitCount")]
		[IsRequired]
		public int UnitCount { get; set; } 

		/// <summary>
		/// The number of order items based on the specified filters.
		/// </summary>
		[JsonProperty("orderItemCount")]
		[IsRequired]
		public int OrderItemCount { get; set; } 

		/// <summary>
		/// The number of orders based on the specified filters.
		/// </summary>
		[JsonProperty("orderCount")]
		[IsRequired]
		public int OrderCount { get; set; } 

		/// <summary>
		/// The average price for an item based on the specified filters. Formula is totalSales/unitCo
		/// unt.
		/// </summary>
		[JsonProperty("averageUnitPrice")]
		[IsRequired]
		public Money AverageUnitPrice { get; set; } 

		/// <summary>
		/// The total ordered product sales for all orders based on the specified filters.
		/// </summary>
		[JsonProperty("totalSales")]
		[IsRequired]
		public Money TotalSales { get; set; } 
	}
}
