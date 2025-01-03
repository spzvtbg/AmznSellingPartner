namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Updated inventory details for an item.
	/// </summary>
	public class ItemDetails : BaseClass
	{
		/// <summary>
		/// The buyer selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifie
		/// should be submitted.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifi
		/// r should be submitted.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Total item quantity available in the warehouse.
		/// </summary>
		[IsRequired]
		[JsonProperty("availableQuantity")]
		public ItemQuantity AvailableQuantity { get; set; }

		/// <summary>
		/// When true, the item is permanently unavailable.
		/// </summary>
		[JsonProperty("isObsolete")]
		public bool IsObsolete { get; set; }
	}
}
