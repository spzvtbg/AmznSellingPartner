namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	/// <summary>
	/// Product instance attribute that is not described at the SKU level in the catalog.
	/// </summary>
	public class ProductAttribute : BaseClass
	{
		/// <summary>
		/// Product attribute name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 

		/// <summary>
		/// Product attribute value.
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; } 
	}
}
