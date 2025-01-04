namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getInvoiceStatus operation.
	/// </summary>
	public class GetInvoiceStatusResponse : BaseClass
	{
		/// <summary>
		/// The payload for the getInvoiceStatus operation.
		/// </summary>
		[JsonProperty("payload")]
		public ShipmentInvoiceStatusResponse Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
