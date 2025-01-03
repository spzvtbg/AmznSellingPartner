namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Transportation details for this shipment.
	/// </summary>
	public class TransportationDetails : BaseClass
	{
		/// <summary>
		/// The type of shipment.
		/// </summary>
		[JsonProperty("shipMode")]
		public ShipMode ShipMode { get; set; }

		/// <summary>
		/// The mode of transportation for this shipment.
		/// </summary>
		[JsonProperty("transportationMode")]
		public TransportationMode TransportationMode { get; set; }

		/// <summary>
		/// Date when shipment is performed by the Vendor to Buyer
		/// </summary>
		[JsonProperty("shippedDate")]
		public DateTime ShippedDate { get; set; }

		/// <summary>
		/// Estimated Date on which shipment will be delivered from Vendor to Buyer
		/// </summary>
		[JsonProperty("estimatedDeliveryDate")]
		public DateTime EstimatedDeliveryDate { get; set; }

		/// <summary>
		/// Date on which shipment will be delivered from Vendor to Buyer
		/// </summary>
		[JsonProperty("shipmentDeliveryDate")]
		public DateTime ShipmentDeliveryDate { get; set; }

		/// <summary>
		/// Indicates the carrier details and their contact informations
		/// </summary>
		[JsonProperty("carrierDetails")]
		public CarrierDetails CarrierDetails { get; set; }

		/// <summary>
		/// The Bill of Lading (BOL) number is a unique number assigned to each shipment of goods by the vendor or
		/// shipper during the creation of the Bill of Lading. This number must be unique for every shipment and
		/// cannot be a date/time or single character. The BOL numer is mandatory in Shipment Confirmation message
		/// for FTL and LTL shipments, and must match the paper BOL provided with the shipment. Instead of BOL, an
		/// alternative reference number (like Delivery Note Number) for the shipment can also be sent in this f
		/// ield.
		/// </summary>
		[JsonProperty("billOfLadingNumber")]
		public string BillOfLadingNumber { get; set; }
	}
}
