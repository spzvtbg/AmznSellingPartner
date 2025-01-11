namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CurrentShipmentStatus
	{
		/// <summary>
		/// Shipment request was received by buyer.
		/// </summary>
		[EnumMember(Value = "Created")]
		Created,

		[EnumMember(Value = "TransportationRequested")]
		TransportationRequested,

		[EnumMember(Value = "CarrierAssigned")]
		CarrierAssigned,

		/// <summary>
		/// Shipment sent to buyer warehouse.
		/// </summary>
		[EnumMember(Value = "Shipped")]
		Shipped,

		/// <summary>
		/// Buyer to confirm with the carrier for pickup
		/// </summary>
		[EnumMember(Value = "Transportation requested")]
		Transportation_requested,

		/// <summary>
		/// Shipment is assigned to a carrier for pickup from vendor warehouse to Buyer FC / Warehouse
		/// .
		/// </summary>
		[EnumMember(Value = "Carrier assigned")]
		Carrier_assigned,
	}
}
