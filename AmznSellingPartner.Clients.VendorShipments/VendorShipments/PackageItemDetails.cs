namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Item details for be provided for every item in shipment at either the item or carton or pallet level, whicheve
	/// is appropriate.
	/// </summary>
	public class PackageItemDetails : BaseClass
	{
		/// <summary>
		/// The purchase order number for the shipment being confirmed. If the items in this shipment belong to multiple p
		/// rchase order numbers that are in particular carton or pallet within the shipment, then provide the purchaseOrd
		/// rNumber at the appropriate carton or pallet level. Formatting Notes: 8-character alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The batch or lot number associates an item with information the manufacturer considers relevant for traceabili
		/// y of the trade item to which the Element String is applied. The data may refer to the trade item itself or to
		/// tems contained. This field is mandatory for all perishable items.
		/// </summary>
		[JsonProperty("lotNumber")]
		public string LotNumber { get; set; }

		/// <summary>
		/// Either expiryDate or mfgDate and expiryAfterDuration are mandatory for perishable items.
		/// </summary>
		[JsonProperty("expiry")]
		public Expiry Expiry { get; set; }
	}
}
