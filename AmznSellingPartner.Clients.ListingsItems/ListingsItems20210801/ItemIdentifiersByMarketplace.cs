namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;

	/// <summary>
	/// Identity attributes associated with the item in the Amazon catalog for the indicated Amazon marketplace
	/// </summary>
	public class ItemIdentifiersByMarketplace : BaseClass
	{
		/// <summary>
		/// A marketplace identifier
		/// Identifies the Amazon marketplace for the listings item
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) of the listings item
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }
	}
}
