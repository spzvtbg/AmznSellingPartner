namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The error response schema for the `confirmShipment` operation
	/// </summary>
	public class ConfirmShipmentErrorResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `confirmShipment` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
