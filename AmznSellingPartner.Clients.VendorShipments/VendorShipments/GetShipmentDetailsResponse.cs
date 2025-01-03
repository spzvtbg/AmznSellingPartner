namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the GetShipmentDetails operation
	/// </summary>
	public class GetShipmentDetailsResponse : BaseClass
	{
		[JsonProperty("payload")]
		public ShipmentDetails Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
