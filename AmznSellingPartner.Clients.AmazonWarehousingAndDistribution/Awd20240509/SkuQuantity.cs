namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Quantity details for a SKU as part of a shipment
	/// </summary>
	public class SkuQuantity : BaseClass
	{
		[JsonProperty("expectedQuantity")]
		[IsRequired]
		public InventoryQuantity ExpectedQuantity { get; set; } 

		[JsonProperty("receivedQuantity")]
		public InventoryQuantity ReceivedQuantity { get; set; } 

		/// <summary>
		/// The merchant stock keeping unit
		/// </summary>
		[JsonProperty("sku")]
		[IsRequired]
		public string Sku { get; set; } 
	}
}
