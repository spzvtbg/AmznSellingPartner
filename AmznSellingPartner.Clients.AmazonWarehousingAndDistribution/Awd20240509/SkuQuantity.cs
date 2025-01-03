namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Quantity details for a SKU as part of a shipment
	/// </summary>
	public class SkuQuantity : BaseClass
	{
		[IsRequired]
		[JsonProperty("expectedQuantity")]
		public InventoryQuantity ExpectedQuantity { get; set; }

		[JsonProperty("receivedQuantity")]
		public InventoryQuantity ReceivedQuantity { get; set; }

		/// <summary>
		/// The merchant stock keeping unit
		/// </summary>
		[IsRequired]
		[JsonProperty("sku")]
		public string Sku { get; set; }
	}
}
