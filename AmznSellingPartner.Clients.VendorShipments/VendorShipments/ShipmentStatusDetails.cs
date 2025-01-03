namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Shipment Status details
	/// </summary>
	public class ShipmentStatusDetails : BaseClass
	{
		/// <summary>
		/// Current status of the shipment on whether it is picked up or scheduled
		/// </summary>
		[JsonProperty("shipmentStatus")]
		public ShipmentStatus ShipmentStatus { get; set; }

		/// <summary>
		/// Date and time on last status update received for the shipment
		/// </summary>
		[JsonProperty("shipmentStatusDate")]
		public DateTime ShipmentStatusDate { get; set; }
	}
}
