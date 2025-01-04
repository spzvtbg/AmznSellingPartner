namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the GetShipmentLabels operation.
	/// </summary>
	public class GetShipmentLabels : BaseClass
	{
		[JsonProperty("payload")]
		public TransportationLabels Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
