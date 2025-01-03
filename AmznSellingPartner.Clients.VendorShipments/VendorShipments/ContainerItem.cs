namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Carton/Pallet level details for the item
	/// </summary>
	public class ContainerItem : BaseClass
	{
		/// <summary>
		/// The reference number for the item
		/// Please provide the itemSequenceNumber from the 'items' segment to refer to that item's details here
		/// </summary>
		[IsRequired]
		[JsonProperty("itemReference")]
		public string ItemReference { get; set; }

		/// <summary>
		/// Total item quantity shipped in this carton/pallet
		/// </summary>
		[IsRequired]
		[JsonProperty("shippedQuantity")]
		public ItemQuantity ShippedQuantity { get; set; }

		[JsonProperty("itemDetails")]
		public ItemDetails ItemDetails { get; set; }
	}
}
