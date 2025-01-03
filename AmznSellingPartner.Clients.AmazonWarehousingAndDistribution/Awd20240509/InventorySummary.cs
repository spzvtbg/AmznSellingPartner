namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Summary of inventory per SKU.
	/// </summary>
	public class InventorySummary : BaseClass
	{
		/// <summary>
		/// The expiration details of the inventory. This object will only appear if the `details` parameter in the
		/// request is set to `SHOW`.
		/// </summary>
		[JsonProperty("expirationDetails")]
		public List<ExpirationDetails> ExpirationDetails { get; set; }

		[JsonProperty("inventoryDetails")]
		public InventoryDetails InventoryDetails { get; set; }

		/// <summary>
		/// The seller or merchant SKU.
		/// </summary>
		[IsRequired]
		[JsonProperty("sku")]
		public string Sku { get; set; }

		/// <summary>
		/// Total quantity that is in-transit from the seller and has not yet been received at an AWD Distribution
		/// Center
		/// </summary>
		[JsonProperty("totalInboundQuantity")]
		public long TotalInboundQuantity { get; set; }

		/// <summary>
		/// Total quantity that is present in AWD distribution centers.
		/// </summary>
		[JsonProperty("totalOnhandQuantity")]
		public long TotalOnhandQuantity { get; set; }
	}
}
