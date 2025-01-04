namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents the ineligibility reason for one SKU.
	/// </summary>
	public class SkuIneligibilityReason : BaseClass
	{
		/// <summary>
		/// Code for the SKU ineligibility.
		/// </summary>
		[JsonProperty("code")]
		[IsRequired]
		public string Code { get; set; }

		/// <summary>
		/// Detailed description of the SKU ineligibility.
		/// </summary>
		[JsonProperty("description")]
		[IsRequired]
		public string Description { get; set; }
	}
}
