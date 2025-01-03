namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Item details for be provided for every item in shipment at either the item or carton or pallet level, whicheve
	/// is appropriate.
	/// </summary>
	public class PurchaseOrderItemDetails : BaseClass
	{
		/// <summary>
		/// Maximum retail price of the item being shipped.
		/// </summary>
		[JsonProperty("maximumRetailPrice")]
		public Money MaximumRetailPrice { get; set; }
	}
}
