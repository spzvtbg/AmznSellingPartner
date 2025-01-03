namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;

	/// <summary>
	/// Individual dimension value of an Amazon catalog item or item package.
	/// </summary>
	public class Dimension : BaseClass
	{
		/// <summary>
		/// Measurement unit of the dimension value.
		/// </summary>
		[JsonProperty("unit")]
		public string Unit { get; set; }

		/// <summary>
		/// Numeric dimension value.
		/// </summary>
		[JsonProperty("value")]
		public double Value { get; set; }
	}
}
