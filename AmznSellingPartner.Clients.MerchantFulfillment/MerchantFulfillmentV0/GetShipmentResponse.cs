namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema
	/// </summary>
	public class GetShipmentResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getShipment` operation
		/// </summary>
		[JsonProperty("payload")]
		public Shipment Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during this operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
