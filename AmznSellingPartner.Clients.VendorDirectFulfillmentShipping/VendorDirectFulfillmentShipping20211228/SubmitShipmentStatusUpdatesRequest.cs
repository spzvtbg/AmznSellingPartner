namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the `submitShipmentStatusUpdates` operation.
	/// </summary>
	public class SubmitShipmentStatusUpdatesRequest : BaseClass
	{
		/// <summary>
		/// Contains a list of one or more `ShipmentStatusUpdate` objects. Each `ShipmentStatusUpdate` object represents a
		/// update to the status of a specific shipment.
		/// </summary>
		[MinItems(1)]
		[JsonProperty("shipmentStatusUpdates")]
		public List<ShipmentStatusUpdate> ShipmentStatusUpdates { get; set; }
	}
}
