namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the submitShipmentConfirmations operation.
	/// </summary>
	public class SubmitShipmentConfirmationsRequest : BaseClass
	{
		/// <summary>
		/// Array of `ShipmentConfirmation` objects. Each `ShipmentConfirmation` object represents the confirmation detail
		/// for a specific shipment.
		/// </summary>
		[JsonProperty("shipmentConfirmations")]
		public List<ShipmentConfirmation> ShipmentConfirmations { get; set; }
	}
}
