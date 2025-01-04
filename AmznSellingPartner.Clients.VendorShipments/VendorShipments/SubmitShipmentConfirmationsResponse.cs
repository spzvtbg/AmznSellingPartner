namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the SubmitShipmentConfirmations operation.
	/// </summary>
	public class SubmitShipmentConfirmationsResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the SubmitShipmentConfirmations operation.
		/// </summary>
		[JsonProperty("payload")]
		public TransactionReference Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
