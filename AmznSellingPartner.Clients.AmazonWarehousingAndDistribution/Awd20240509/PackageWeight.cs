namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents the weight of the package with a unit of measurement.
	/// </summary>
	public class PackageWeight : BaseClass
	{
		/// <summary>
		/// Unit of measurement for the package weight.
		/// </summary>
		[JsonProperty("unitOfMeasurement")]
		[IsRequired]
		public WeightUnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// The package weight value.
		/// </summary>
		[JsonProperty("weight")]
		[IsRequired]
		public double Weight { get; set; }
	}
}
