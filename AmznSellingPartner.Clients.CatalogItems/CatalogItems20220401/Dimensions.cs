namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;

	/// <summary>
	/// Dimensions of an Amazon catalog item or item in its packaging
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// Height of an item or item package
		/// </summary>
		[JsonProperty("height")]
		public Dimension Height { get; set; }

		/// <summary>
		/// Length of an item or item package
		/// </summary>
		[JsonProperty("length")]
		public Dimension Length { get; set; }

		/// <summary>
		/// Weight of an item or item package
		/// </summary>
		[JsonProperty("weight")]
		public Dimension Weight { get; set; }

		/// <summary>
		/// Width of an item or item package
		/// </summary>
		[JsonProperty("width")]
		public Dimension Width { get; set; }
	}
}
