namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Sales rank of an Amazon catalog item by website display group.
	/// </summary>
	public class ItemDisplayGroupSalesRank : BaseClass
	{
		/// <summary>
		/// Name of the website display group associated with the sales rank
		/// </summary>
		[JsonProperty("websiteDisplayGroup")]
		[IsRequired]
		public string WebsiteDisplayGroup { get; set; }

		/// <summary>
		/// Title, or name, of the sales rank.
		/// </summary>
		[JsonProperty("title")]
		[IsRequired]
		public string Title { get; set; }

		/// <summary>
		/// Corresponding Amazon retail website link, or URL, for the sales rank.
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// Sales rank value.
		/// </summary>
		[JsonProperty("rank")]
		[IsRequired]
		public int Rank { get; set; }
	}
}
