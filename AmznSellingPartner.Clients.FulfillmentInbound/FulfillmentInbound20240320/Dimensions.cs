namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Measurement of a package's dimensions.
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The height of a package.
		/// </summary>
		[JsonProperty("height")]
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		public double Height { get; set; } 

		/// <summary>
		/// The length of a package.
		/// </summary>
		[JsonProperty("length")]
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		public double Length { get; set; } 

		[JsonProperty("unitOfMeasurement")]
		[IsRequired]
		public UnitOfMeasurement UnitOfMeasurement { get; set; } 

		/// <summary>
		/// The width of a package.
		/// </summary>
		[JsonProperty("width")]
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		public double Width { get; set; } 
	}
}
