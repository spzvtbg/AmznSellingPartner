namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of item quantity.
	/// </summary>
	public class ItemQuantity : BaseClass
	{
		/// <summary>
		/// Quantity of units shipped for a specific item at a shipment level. If the item is present only in certain
		/// packages or pallets within the shipment, please provide this at the appropriate package or pallet le
		/// vel.
		/// </summary>
		[JsonProperty("amount")]
		[IsRequired]
		public int Amount { get; set; } 

		/// <summary>
		/// Unit of measure for the shipped quantity.
		/// </summary>
		[JsonProperty("unitOfMeasure")]
		[IsRequired]
		public string UnitOfMeasure { get; set; } 
	}
}
