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
		/// If there are order level eligibility issues, then this list will contain those error codes and descr
		/// iptions.
		/// </summary>
		[JsonProperty("ineligibilityReasons")]
		public List<OrderIneligibilityReason> IneligibilityReasons { get; set; } 

		/// <summary>
		/// Details on SKU eligibility for each inbound package.
		/// </summary>
		[JsonProperty("packagesToInbound")]
		[IsRequired]
		public List<SkuEligibility> PackagesToInbound { get; set; } 

		/// <summary>
		/// Timestamp when the eligibility check is performed.
		/// </summary>
		[JsonProperty("previewedAt")]
		[IsRequired]
		public DateTime PreviewedAt { get; set; } 

		[JsonProperty("status")]
		[IsRequired]
		public InboundEligibilityStatus Status { get; set; } 
	}
}
