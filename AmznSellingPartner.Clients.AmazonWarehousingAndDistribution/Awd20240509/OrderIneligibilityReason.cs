namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents one ineligibility reason for the order (there can be multiple reasons).
	/// </summary>
	public class OrderIneligibilityReason : BaseClass
	{
		/// <summary>
		/// Code for the order ineligibility.
		/// </summary>
		[JsonProperty("code")]
		[IsRequired]
		public string Code { get; set; }

		/// <summary>
		/// Description detailing the ineligibility reason of the order.
		/// </summary>
		[JsonProperty("description")]
		[IsRequired]
		public string Description { get; set; }
	}
}
