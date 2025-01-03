namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of item quantity.
	/// </summary>
	public class ItemQuantity : BaseClass
	{
		/// <summary>
		/// Amount of units shipped for a specific item at a shipment level. If the item is present only in certain carton
		/// or pallets within the shipment, please provide this at the appropriate carton or pallet level.
		/// </summary>
		[IsRequired]
		[JsonProperty("amount")]
		public int Amount { get; set; }

		/// <summary>
		/// Unit of measure for the shipped quantity.
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		/// <summary>
		/// The case size, in the event that we ordered using cases. Otherwise, 1.
		/// </summary>
		[JsonProperty("unitSize")]
		public int UnitSize { get; set; }

		[JsonProperty("totalWeight")]
		public TotalWeight TotalWeight { get; set; }
	}
}
