namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Payload for creating an inbound order.
	/// </summary>
	public class InboundOrderCreationData : BaseClass
	{
		/// <summary>
		/// Reference ID that can be used to correlate the order with partner resources.
		/// </summary>
		[JsonProperty("externalReferenceId")]
		public string ExternalReferenceId { get; set; } 

		/// <summary>
		/// Origin address from where the inbound order will be shipped.
		/// </summary>
		[JsonProperty("originAddress")]
		[IsRequired]
		public Address OriginAddress { get; set; } 

		/// <summary>
		/// List of packages to be inbounded.
		/// </summary>
		[JsonProperty("packagesToInbound")]
		[IsRequired]
		[MinItems(1)]
		public List<DistributionPackageQuantity> PackagesToInbound { get; set; } 

		[JsonProperty("preferences")]
		public InboundPreferences Preferences { get; set; } 

		/// <summary>
		/// Estimated date by when goods have to be picked up.
		/// </summary>
		[JsonProperty("shipBy")]
		public DateTime ShipBy { get; set; } 
	}
}
