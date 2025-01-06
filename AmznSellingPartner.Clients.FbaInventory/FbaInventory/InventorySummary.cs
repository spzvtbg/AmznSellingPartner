namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Inventory summary for a specific item.
	/// </summary>
	public class InventorySummary : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of an item.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; } 

		/// <summary>
		/// Amazon's fulfillment network SKU identifier.
		/// </summary>
		[JsonProperty("fnSku")]
		public string FnSku { get; set; } 

		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; } 

		/// <summary>
		/// The condition of the item as described by the seller (for example, New Item).
		/// </summary>
		[JsonProperty("condition")]
		public string Condition { get; set; } 

		[JsonProperty("inventoryDetails")]
		public InventoryDetails InventoryDetails { get; set; } 

		/// <summary>
		/// The date and time that any quantity was last updated.
		/// </summary>
		[JsonProperty("lastUpdatedTime")]
		public DateTimeValue LastUpdatedTime { get; set; } 

		/// <summary>
		/// The localized language product title of the item within the specific marketplace.
		/// </summary>
		[JsonProperty("productName")]
		public string ProductName { get; set; } 

		/// <summary>
		/// The total number of units in an inbound shipment or in Amazon fulfillment centers.
		/// </summary>
		[JsonProperty("totalQuantity")]
		public int TotalQuantity { get; set; } 

		/// <summary>
		/// A list of seller-enrolled stores that apply to this seller SKU.
		/// </summary>
		[JsonProperty("stores")]
		public List<string> Stores { get; set; } 
	}
}
