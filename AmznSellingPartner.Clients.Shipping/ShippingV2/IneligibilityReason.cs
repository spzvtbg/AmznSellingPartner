namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The reason why a shipping service offering is ineligible.
	/// </summary>
	public class IneligibilityReason : BaseClass
	{
		[JsonProperty("code")]
		[IsRequired]
		public IneligibilityReasonCode Code { get; set; }

		/// <summary>
		/// The ineligibility reason.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		public string Message { get; set; }
	}
}
