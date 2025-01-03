namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The reason why a shipping service offering is ineligible
	/// </summary>
	public class IneligibilityReason : BaseClass
	{
		[IsRequired]
		[JsonProperty("code")]
		public IneligibilityReasonCode Code { get; set; }

		/// <summary>
		/// The ineligibility reason
		/// </summary>
		[IsRequired]
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
