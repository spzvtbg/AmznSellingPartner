namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an AWD distribution package.
	/// </summary>
	public class DistributionPackage : BaseClass
	{
		/// <summary>
		/// The contents appropriate for the type.
		/// </summary>
		[IsRequired]
		[JsonProperty("contents")]
		public DistributionPackageContents Contents { get; set; }

		/// <summary>
		/// Measurements of a package, including weight, volume, and dimensions.
		/// </summary>
		[IsRequired]
		[JsonProperty("measurements")]
		public MeasurementData Measurements { get; set; }

		/// <summary>
		/// Type of distribution package.
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public DistributionPackageType Type { get; set; }
	}
}
