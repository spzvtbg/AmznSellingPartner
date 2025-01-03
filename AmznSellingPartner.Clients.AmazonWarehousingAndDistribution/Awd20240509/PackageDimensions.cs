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
		[IsRequired]
		[JsonProperty("height")]
		public double Height { get; set; }

		/// <summary>
		/// Length of the package.
		/// </summary>
		[IsRequired]
		[JsonProperty("length")]
		public double Length { get; set; }

		/// <summary>
		/// Unit of measurement for package dimensions.
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasurement")]
		public DimensionUnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// Width of the package.
		/// </summary>
		[IsRequired]
		[JsonProperty("width")]
		public double Width { get; set; }
	}
}
