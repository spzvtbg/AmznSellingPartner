namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;

	/// <summary>
	/// A JSON object that contains structured item attribute data keyed by attribute name. Catalog item attributes co
	/// form to the related product type definitions available in the Selling Partner API for Product Type Definitions
	/// 
	/// </summary>
	public class ItemAttributes : BaseClass
	{
		[JsonProperty("AdditionalValue")]
		public bool? AdditionalValue { get; set; }
	}
}
