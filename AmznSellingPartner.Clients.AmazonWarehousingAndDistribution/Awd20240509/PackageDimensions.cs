namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Dimensions of the package.
	/// </summary>
	public class PackageDimensions : BaseClass
	{
		/// <summary>
		/// Height of the package.
		/// </summary>
		[JsonProperty("height")]
		[IsRequired]
		public double Height { get; set; }

		/// <summary>
		/// Length of the package.
		/// </summary>
		[JsonProperty("length")]
		[IsRequired]
		public double Length { get; set; }

		/// <summary>
		/// Unit of measurement for package dimensions.
		/// </summary>
		[JsonProperty("unitOfMeasurement")]
		[IsRequired]
		public DimensionUnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// Width of the package.
		/// </summary>
		[JsonProperty("width")]
		[IsRequired]
		public double Width { get; set; }
	}
}
