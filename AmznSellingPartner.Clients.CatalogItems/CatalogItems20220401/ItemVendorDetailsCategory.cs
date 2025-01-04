namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;

	/// <summary>
	/// Product category or subcategory associated with an Amazon catalog item.
	/// </summary>
	public class ItemVendorDetailsCategory : BaseClass
	{
		/// <summary>
		/// Display name of the product category or subcategory
		/// </summary>
		[JsonProperty("displayName")]
		public string DisplayName { get; set; } 

		/// <summary>
		/// Value (code) of the product category or subcategory.
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; } 
	}
}
