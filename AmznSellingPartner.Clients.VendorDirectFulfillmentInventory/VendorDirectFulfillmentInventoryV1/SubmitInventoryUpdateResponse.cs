namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the submitInventoryUpdate operation.
	/// </summary>
	public class SubmitInventoryUpdateResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the submitInventoryUpdate operation.
		/// </summary>
		[JsonProperty("payload")]
		public TransactionReference Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
