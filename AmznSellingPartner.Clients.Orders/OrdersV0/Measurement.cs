namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Measurement information for an order item
	/// </summary>
	public class Measurement : BaseClass
	{
		/// <summary>
		/// The unit of measure
		/// </summary>
		[IsRequired]
		[JsonProperty("Unit")]
		public Unit Unit { get; set; }

		/// <summary>
		/// The measurement value
		/// </summary>
		[IsRequired]
		[JsonProperty("Value")]
		public double Value { get; set; }
	}
}
