namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the SubmitShipmentConfirmations operation.
	/// </summary>
	public class SubmitShipmentConfirmationsRequest : BaseClass
	{
		/// <summary>
		/// A list of one or more shipment confirmations.
		/// </summary>
		[JsonProperty("shipmentConfirmations")]
		public List<ShipmentConfirmation> ShipmentConfirmations { get; set; }
	}
}
