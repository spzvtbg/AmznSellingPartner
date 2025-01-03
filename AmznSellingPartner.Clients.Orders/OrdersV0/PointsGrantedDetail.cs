namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The number of Amazon Points offered with the purchase of an item, and their monetary value.
	/// </summary>
	public class PointsGrantedDetail : BaseClass
	{
		/// <summary>
		/// The number of Amazon Points granted with the purchase of an item.
		/// </summary>
		[JsonProperty("PointsNumber")]
		public int PointsNumber { get; set; }

		/// <summary>
		/// The monetary value of the Amazon Points granted.
		/// </summary>
		[JsonProperty("PointsMonetaryValue")]
		public Money PointsMonetaryValue { get; set; }
	}
}
