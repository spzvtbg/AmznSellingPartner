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
		[IsRequired]
		[JsonProperty("unitOfMeasurement")]
		public WeightUnitOfMeasurement UnitOfMeasurement { get; set; }

		/// <summary>
		/// The package weight value.
		/// </summary>
		[IsRequired]
		[JsonProperty("weight")]
		public double Weight { get; set; }
	}
}
