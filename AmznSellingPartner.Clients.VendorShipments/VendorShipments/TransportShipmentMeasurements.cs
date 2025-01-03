namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Shipment measurement details.
	/// </summary>
	public class TransportShipmentMeasurements : BaseClass
	{
		/// <summary>
		/// Total number of cartons present in the shipment. Provide the cartonCount only for non-palletized shi
		/// pments.
		/// </summary>
		[JsonProperty("totalCartonCount")]
		public int TotalCartonCount { get; set; }

		/// <summary>
		/// Total number of Stackable Pallets present in the shipment.
		/// </summary>
		[JsonProperty("totalPalletStackable")]
		public int TotalPalletStackable { get; set; }

		/// <summary>
		/// Total number of Non Stackable Pallets present in the shipment.
		/// </summary>
		[JsonProperty("totalPalletNonStackable")]
		public int TotalPalletNonStackable { get; set; }

		/// <summary>
		/// Total Weight of the shipment.
		/// </summary>
		[JsonProperty("shipmentWeight")]
		public Weight ShipmentWeight { get; set; }

		/// <summary>
		/// Total Volume of the shipment.
		/// </summary>
		[JsonProperty("shipmentVolume")]
		public Volume ShipmentVolume { get; set; }
	}
}
