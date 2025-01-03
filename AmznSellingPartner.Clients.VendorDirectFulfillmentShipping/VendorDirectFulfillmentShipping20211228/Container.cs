namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A container used for shipping and packing items.
	/// </summary>
	public class Container : BaseClass
	{
		/// <summary>
		/// The type of container.
		/// </summary>
		[IsRequired]
		[JsonProperty("containerType")]
		public ContainerType ContainerType { get; set; }

		/// <summary>
		/// The container identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("containerIdentifier")]
		public string ContainerIdentifier { get; set; }

		/// <summary>
		/// The tracking number.
		/// </summary>
		[JsonProperty("trackingNumber")]
		public string TrackingNumber { get; set; }

		/// <summary>
		/// The manifest identifier.
		/// </summary>
		[JsonProperty("manifestId")]
		public string ManifestId { get; set; }

		/// <summary>
		/// The date of the manifest.
		/// </summary>
		[JsonProperty("manifestDate")]
		public string ManifestDate { get; set; }

		/// <summary>
		/// The shipment method. This property is required when calling the `submitShipmentConfirmations` operation,
		/// and optional otherwise.
		/// </summary>
		[JsonProperty("shipMethod")]
		public string ShipMethod { get; set; }

		/// <summary>
		/// SCAC code required for NA VOC vendors only.
		/// </summary>
		[JsonProperty("scacCode")]
		public string ScacCode { get; set; }

		/// <summary>
		/// Carrier required for EU VOC vendors only.
		/// </summary>
		[JsonProperty("carrier")]
		public string Carrier { get; set; }

		/// <summary>
		/// An integer that must be submitted for multi-box shipments only, where one item may come in separate
		/// packages.
		/// </summary>
		[JsonProperty("containerSequenceNumber")]
		public int ContainerSequenceNumber { get; set; }

		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		[IsRequired]
		[JsonProperty("weight")]
		public Weight Weight { get; set; }

		/// <summary>
		/// A list of packed items.
		/// </summary>
		[IsRequired]
		[JsonProperty("packedItems")]
		public List<PackedItem> PackedItems { get; set; }
	}
}
