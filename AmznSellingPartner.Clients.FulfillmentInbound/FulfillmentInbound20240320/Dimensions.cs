namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Measurement of a package's dimensions
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The height of a package
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		[JsonProperty("height")]
		public double Height { get; set; }

		/// <summary>
		/// The length of a package
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		[JsonProperty("length")]
		public double Length { get; set; }

		[IsRequired]
		[JsonProperty("unitOfMeasurement")]
		public UnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// The width of a package
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		[JsonProperty("width")]
		public double Width { get; set; }
	}
}
