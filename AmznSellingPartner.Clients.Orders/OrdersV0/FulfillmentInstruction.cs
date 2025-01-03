namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Contains the instructions about the fulfillment, such as the location from where you want the order filled
	/// </summary>
	public class FulfillmentInstruction : BaseClass
	{
		/// <summary>
		/// The `sourceId` of the location from where you want the order fulfilled
		/// </summary>
		[JsonProperty("FulfillmentSupplySourceId")]
		public string FulfillmentSupplySourceId { get; set; }
	}
}
