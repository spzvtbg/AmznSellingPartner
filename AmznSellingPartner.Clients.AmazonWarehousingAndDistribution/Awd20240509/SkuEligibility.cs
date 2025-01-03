namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents eligibility of one SKU.
	/// </summary>
	public class SkuEligibility : BaseClass
	{
		/// <summary>
		/// If not eligible, these are list of error codes and descriptions.
		/// </summary>
		[JsonProperty("ineligibilityReasons")]
		public List<SkuIneligibilityReason> IneligibilityReasons { get; set; }

		[IsRequired]
		[JsonProperty("packageQuantity")]
		public DistributionPackageQuantity PackageQuantity { get; set; }

		[IsRequired]
		[JsonProperty("status")]
		public InboundEligibilityStatus Status { get; set; }
	}
}
