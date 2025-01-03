namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class MarketplaceParticipation : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplace")]
		public Marketplace Marketplace { get; set; }

		[IsRequired]
		[JsonProperty("participation")]
		public Participation Participation { get; set; }

		/// <summary>
		/// The name of the seller's store as displayed in the marketplace
		/// </summary>
		[IsRequired]
		[JsonProperty("storeName")]
		public string StoreName { get; set; }
	}
}
