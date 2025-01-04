namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The available delivery confirmation options, and the fee charged, if any.
	/// </summary>
	public class AvailableDeliveryExperienceOption : BaseClass
	{
		[JsonProperty("DeliveryExperienceOption")]
		[IsRequired]
		public DeliveryExperienceOption DeliveryExperienceOption { get; set; }

		[JsonProperty("Charge")]
		[IsRequired]
		public CurrencyAmount Charge { get; set; }
	}
}
