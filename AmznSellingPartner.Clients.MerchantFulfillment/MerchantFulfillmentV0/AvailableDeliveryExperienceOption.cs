namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The available delivery confirmation options, and the fee charged, if any
	/// </summary>
	public class AvailableDeliveryExperienceOption : BaseClass
	{
		[IsRequired]
		[JsonProperty("DeliveryExperienceOption")]
		public DeliveryExperienceOption DeliveryExperienceOption { get; set; }

		[IsRequired]
		[JsonProperty("Charge")]
		public CurrencyAmount Charge { get; set; }
	}
}
