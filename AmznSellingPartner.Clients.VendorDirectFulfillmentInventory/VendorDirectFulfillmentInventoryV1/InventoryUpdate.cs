namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Inventory details required to update some or all items for the requested warehouse.
	/// </summary>
	public class InventoryUpdate : BaseClass
	{
		/// <summary>
		/// ID of the selling party or vendor.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// When true, this request contains a full feed. Otherwise, this request contains a partial feed. When sending a
		/// ull feed, you must send information about all items in the warehouse. Any items not in the full feed are updat
		/// d as not available. When sending a partial feed, only include the items that need an update to inventory. The
		/// tatus of other items will remain unchanged.
		/// </summary>
		[IsRequired]
		[JsonProperty("isFullUpdate")]
		public bool IsFullUpdate { get; set; }

		/// <summary>
		/// A list of inventory items with updated details, including quantity available.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<ItemDetails> Items { get; set; }
	}
}
