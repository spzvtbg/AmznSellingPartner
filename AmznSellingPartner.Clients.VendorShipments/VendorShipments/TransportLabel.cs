namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// A list of one or more ShipmentLabels.
	/// </summary>
	public class TransportLabel : BaseClass
	{
		/// <summary>
		/// Date on which label is created.
		/// </summary>
		[JsonProperty("labelCreateDateTime")]
		public DateTime LabelCreateDateTime { get; set; }

		/// <summary>
		/// Indicates the shipment Information details like warehouse and business reference details like ARN, Selling Par
		/// y detail and Vendor Warehouse details
		/// </summary>
		[JsonProperty("shipmentInformation")]
		public ShipmentInformation ShipmentInformation { get; set; }

		/// <summary>
		/// Indicates the label data,format and type associated .
		/// </summary>
		[JsonProperty("labelData")]
		public List<LabelData> LabelData { get; set; }
	}
}
