namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents a distribution package with its respective quantity.
	/// </summary>
	public class DistributionPackageQuantity : BaseClass
	{
		/// <summary>
		/// Number of cases or pallets with the same package configuration.
		/// </summary>
		[JsonProperty("count")]
		[IsRequired]
		public int Count { get; set; }

		[JsonProperty("distributionPackage")]
		[IsRequired]
		public DistributionPackage DistributionPackage { get; set; }
	}
}
