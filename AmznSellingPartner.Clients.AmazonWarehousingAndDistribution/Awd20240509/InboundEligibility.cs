namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents the eligibility status of the inbound packages.
	/// </summary>
	public class InboundEligibility : BaseClass
	{
		/// <summary>
		/// If there are order level eligibility issues, then this list will contain those error codes and descriptions.
		/// </summary>
		[JsonProperty("ineligibilityReasons")]
		public List<OrderIneligibilityReason> IneligibilityReasons { get; set; }

		/// <summary>
		/// Details on SKU eligibility for each inbound package.
		/// </summary>
		[IsRequired]
		[JsonProperty("packagesToInbound")]
		public List<SkuEligibility> PackagesToInbound { get; set; }

		/// <summary>
		/// Timestamp when the eligibility check is performed.
		/// </summary>
		[IsRequired]
		[JsonProperty("previewedAt")]
		public DateTime PreviewedAt { get; set; }

		[IsRequired]
		[JsonProperty("status")]
		public InboundEligibilityStatus Status { get; set; }
	}
}
