namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The error response schema for the `UpdateShipmentStatus` operation.
	/// </summary>
	public class UpdateShipmentStatusErrorResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `UpdateShipmentStatus` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
