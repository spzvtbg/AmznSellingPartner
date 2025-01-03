namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Object representing an excluded benefit that is excluded for an ShippingOffering/Rate
	/// </summary>
	public class ExcludedBenefit : BaseClass
	{
		[IsRequired]
		[JsonProperty("benefit")]
		public string Benefit { get; set; }

		[IsRequired]
		[JsonProperty("reasonCode")]
		public string ReasonCode { get; set; }
	}
}
