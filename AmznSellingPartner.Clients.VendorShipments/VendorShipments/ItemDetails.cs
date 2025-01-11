namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Item details for be provided for every item in shipment at either the item or carton or pallet
	/// level, whichever is appropriate.
	/// </summary>
	public class ItemDetails : BaseClass
	{
		/// <summary>
		/// The purchase order number for the shipment being confirmed. If the items in this shipment belong
		/// to multiple purchase order numbers that are in particular carton or pallet within the shipment,
		/// then provide the purchaseOrderNumber at the appropriate carton or pallet level. Formatting
		/// Notes: 8-character alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// The batch or lot number associates an item with information the manufacturer considers relevant
		/// for traceability of the trade item to which the Element String is applied. The data may refer
		/// to the trade item itself or to items contained. This field is mandatory for all perishable
		/// items.
		/// </summary>
		[JsonProperty("lotNumber")]
		public string LotNumber { get; set; } 

		/// <summary>
		/// Expiry refers to the collection of dates required  for certain items. These could be either
		/// expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items.
		/// </summary>
		[JsonProperty("expiry")]
		public Expiry Expiry { get; set; } 

		/// <summary>
		/// Maximum retail price of the item being shipped.
		/// </summary>
		[JsonProperty("maximumRetailPrice")]
		public Money MaximumRetailPrice { get; set; } 

		/// <summary>
		/// Identification of the instructions on how specified item/carton/pallet should be handled.
		/// </summary>
		[JsonProperty("handlingCode")]
		public HandlingCode HandlingCode { get; set; } 
	}
}
