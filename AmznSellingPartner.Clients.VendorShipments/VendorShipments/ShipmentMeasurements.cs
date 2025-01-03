namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Shipment measurement details.
	/// </summary>
	public class ShipmentMeasurements : BaseClass
	{
		/// <summary>
		/// Gross weight of the shipment.
		/// </summary>
		[JsonProperty("grossShipmentWeight")]
		public Weight GrossShipmentWeight { get; set; }

		/// <summary>
		/// Gross Volume of the shipment.
		/// </summary>
		[JsonProperty("shipmentVolume")]
		public Volume ShipmentVolume { get; set; }

		/// <summary>
		/// Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments
		/// .
		/// </summary>
		[JsonProperty("cartonCount")]
		public int CartonCount { get; set; }

		/// <summary>
		/// Number of pallets present in the shipment. Provide the palletCount only for palletized shipments.
		/// </summary>
		[JsonProperty("palletCount")]
		public int PalletCount { get; set; }
	}
}
