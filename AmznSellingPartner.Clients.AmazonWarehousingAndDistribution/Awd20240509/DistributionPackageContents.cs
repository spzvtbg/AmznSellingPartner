namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents the contents inside a package, which can be products or a nested package
	/// </summary>
	public class DistributionPackageContents : BaseClass
	{
		/// <summary>
		/// This is required only when `DistributionPackageType=PALLET`
		/// </summary>
		[JsonProperty("packages")]
		public List<DistributionPackageQuantity> Packages { get; set; }

		/// <summary>
		/// This is required only when `DistributionPackageType=CASE`
		/// </summary>
		[JsonProperty("products")]
		public List<ProductQuantity> Products { get; set; }
	}
}
