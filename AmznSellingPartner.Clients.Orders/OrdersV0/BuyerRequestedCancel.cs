namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Information about whether or not a buyer requested cancellation.
	/// </summary>
	public class BuyerRequestedCancel : BaseClass
	{
		/// <summary>
		/// Indicate whether the buyer has requested cancellation.  **Possible Values**: `true`, `false`.
		/// </summary>
		[JsonProperty("IsBuyerRequestedCancel")]
		public string IsBuyerRequestedCancel { get; set; }

		/// <summary>
		/// The reason that the buyer requested cancellation.
		/// </summary>
		[JsonProperty("BuyerCancelReason")]
		public string BuyerCancelReason { get; set; }
	}
}
