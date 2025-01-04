namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Sales rank of an Amazon catalog item by classification.
	/// </summary>
	public class ItemClassificationSalesRank : BaseClass
	{
		/// <summary>
		/// Identifier of the classification associated with the sales rank.
		/// </summary>
		[JsonProperty("classificationId")]
		[IsRequired]
		public string ClassificationId { get; set; } 

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
