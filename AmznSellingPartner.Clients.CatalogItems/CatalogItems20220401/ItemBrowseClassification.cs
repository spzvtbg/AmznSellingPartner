namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Classification (browse node) associated with an Amazon catalog item
	/// </summary>
	public class ItemBrowseClassification : BaseClass
	{
		/// <summary>
		/// Display name for the classification (browse node)
		/// </summary>
		[IsRequired]
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// Identifier of the classification (browse node identifier)
		/// </summary>
		[IsRequired]
		[JsonProperty("classificationId")]
		public string ClassificationId { get; set; }

		/// <summary>
		/// Parent classification (browse node) of the current classification
		/// </summary>
		[JsonProperty("parent")]
		public ItemBrowseClassification Parent { get; set; }
	}
}
