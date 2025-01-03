namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents the ineligibility reason for one SKU
	/// </summary>
	public class SkuIneligibilityReason : BaseClass
	{
		/// <summary>
		/// Code for the SKU ineligibility
		/// </summary>
		[IsRequired]
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// Detailed description of the SKU ineligibility
		/// </summary>
		[IsRequired]
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
