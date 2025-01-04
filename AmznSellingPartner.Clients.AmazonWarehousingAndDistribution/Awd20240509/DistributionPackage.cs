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
		[JsonProperty("contents")]
		[IsRequired]
		public DistributionPackageContents Contents { get; set; } 

		/// <summary>
		/// Measurements of a package, including weight, volume, and dimensions.
		/// </summary>
		[JsonProperty("measurements")]
		[IsRequired]
		public MeasurementData Measurements { get; set; } 

		/// <summary>
		/// Type of distribution package.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		public DistributionPackageType Type { get; set; } 
	}
}
