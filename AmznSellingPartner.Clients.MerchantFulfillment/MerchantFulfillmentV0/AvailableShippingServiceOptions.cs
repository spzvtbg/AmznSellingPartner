namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The available shipping service options.
	/// </summary>
	public class AvailableShippingServiceOptions : BaseClass
	{
		[JsonProperty("AvailableCarrierWillPickUpOptions")]
		[IsRequired]
		public AvailableCarrierWillPickUpOptionsList AvailableCarrierWillPickUpOptions { get; set; }

		[JsonProperty("AvailableDeliveryExperienceOptions")]
		[IsRequired]
		public AvailableDeliveryExperienceOptionsList AvailableDeliveryExperienceOptions { get; set; }
	}
}
