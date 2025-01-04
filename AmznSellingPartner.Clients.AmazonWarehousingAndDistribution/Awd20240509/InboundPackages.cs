namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents the packages to inbound.
	/// </summary>
	public class InboundPackages : BaseClass
	{
		/// <summary>
		/// List of packages to be inbounded.
		/// </summary>
		[JsonProperty("packagesToInbound")]
		[IsRequired]
		[MinItems(1)]
		public List<DistributionPackageQuantity> PackagesToInbound { get; set; }
	}
}
