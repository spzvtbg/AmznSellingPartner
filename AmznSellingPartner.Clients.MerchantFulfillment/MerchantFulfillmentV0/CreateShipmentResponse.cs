namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema.
	/// </summary>
	public class CreateShipmentResponse : BaseClass
	{
		/// <summary>
		/// Shipment information.
		/// </summary>
		[JsonProperty("payload")]
		public Shipment Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `createShipment` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
