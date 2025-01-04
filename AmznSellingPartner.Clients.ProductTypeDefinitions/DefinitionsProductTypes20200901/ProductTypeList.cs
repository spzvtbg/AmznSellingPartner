namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of Amazon product types with definitions available.
	/// </summary>
	public class ProductTypeList : BaseClass
	{
		[JsonProperty("productTypes")]
		[IsRequired]
		public List<ProductType> ProductTypes { get; set; } 

		/// <summary>
		/// Amazon product type version identifier.
		/// </summary>
		[JsonProperty("productTypeVersion")]
		[IsRequired]
		public string ProductTypeVersion { get; set; } 
	}
}
