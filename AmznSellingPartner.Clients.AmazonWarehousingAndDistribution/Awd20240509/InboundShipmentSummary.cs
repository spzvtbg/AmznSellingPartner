namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Summary for an AWD inbound shipment containing the shipment ID, which can be used to retrieve the actual
	/// shipment.
	/// </summary>
	public class InboundShipmentSummary : BaseClass
	{
		/// <summary>
		/// Timestamp when the shipment was created.
		/// </summary>
		[JsonProperty("createdAt")]
		public DateTimeValue CreatedAt { get; set; } 

		/// <summary>
		/// Optional client-provided reference ID that can be used to correlate this shipment with client resources.
		/// For example, to map this shipment to an internal bookkeeping order record.
		/// </summary>
		[JsonProperty("externalReferenceId")]
		public string ExternalReferenceId { get; set; } 

		/// <summary>
		/// The AWD inbound order ID that this inbound shipment belongs to.
		/// </summary>
		[JsonProperty("orderId")]
		[IsRequired]
		[MinLength(1)]
		public string OrderId { get; set; } 

		/// <summary>
		/// A unique shipment ID.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[MinLength(1)]
		public string ShipmentId { get; set; } 

		[JsonProperty("shipmentStatus")]
		[IsRequired]
		public InboundShipmentStatus ShipmentStatus { get; set; } 

		/// <summary>
		/// Timestamp when the shipment was updated.
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTimeValue UpdatedAt { get; set; } 
	}
}
