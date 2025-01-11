namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	public class ReceivingStatus : BaseClass
	{
		/// <summary>
		/// Receive status of the line item.
		/// </summary>
		[JsonProperty("receiveStatus")]
		public ReceiveStatus ReceiveStatus { get; set; } 

		/// <summary>
		/// The total item quantity received by the buyer so far.
		/// </summary>
		[JsonProperty("receivedQuantity")]
		public ItemQuantity ReceivedQuantity { get; set; } 

		/// <summary>
		/// The date when the most recent item was received at the buyer's warehouse. Must be in ISO-8601
		/// date/time format.
		/// </summary>
		[JsonProperty("lastReceiveDate")]
		public DateTimeValue LastReceiveDate { get; set; } 
	}
}
