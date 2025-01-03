namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The shipment invoice status information
	/// </summary>
	public class ShipmentInvoiceStatusInfo : BaseClass
	{
		/// <summary>
		/// The Amazon-defined shipment identifier
		/// </summary>
		[JsonProperty("AmazonShipmentId")]
		public string AmazonShipmentId { get; set; }

		[JsonProperty("InvoiceStatus")]
		public ShipmentInvoiceStatus InvoiceStatus { get; set; }
	}
}
