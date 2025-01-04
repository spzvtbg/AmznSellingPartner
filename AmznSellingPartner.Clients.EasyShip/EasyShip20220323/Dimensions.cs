namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;

	/// <summary>
	/// The dimensions of the scheduled package.
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The length dimension.
		/// </summary>
		[JsonProperty("length")]
		public Dimension Length { get; set; } 

		/// <summary>
		/// The width dimension.
		/// </summary>
		[JsonProperty("width")]
		public Dimension Width { get; set; } 

		/// <summary>
		/// The height dimension.
		/// </summary>
		[JsonProperty("height")]
		public Dimension Height { get; set; } 

		[JsonProperty("unit")]
		public UnitOfLength Unit { get; set; } 

		/// <summary>
		/// Identifier for custom package dimensions.
		/// </summary>
		[JsonProperty("identifier")]
		public String Identifier { get; set; } 
	}
}
