namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Role of an individual contributor in the creation of an item, such as author or actor
	/// </summary>
	public class ItemContributorRole : BaseClass
	{
		/// <summary>
		/// Display name of the role in the requested locale, such as Author or Actor
		/// </summary>
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// Role value for the Amazon catalog item, such as author or actor
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
