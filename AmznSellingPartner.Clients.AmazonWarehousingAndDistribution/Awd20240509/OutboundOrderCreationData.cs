namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Payload for creating an outbound order.
	/// </summary>
	public class OutboundOrderCreationData : BaseClass
	{
		/// <summary>
		/// Order preferences for the outbound order.
		/// </summary>
		[JsonProperty("orderPreferences")]
		public List<OrderAttribute> OrderPreferences { get; set; }

		/// <summary>
		/// List of packages to be outbound.
		/// </summary>
		[JsonProperty("packagesToOutbound")]
		public List<DistributionPackageQuantity> PackagesToOutbound { get; set; }

		/// <summary>
		/// List of product units to be outbound.
		/// </summary>
		[JsonProperty("productsToOutbound")]
		public List<ProductQuantity> ProductsToOutbound { get; set; }
	}
}
