namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The available shipping service options
	/// </summary>
	public class AvailableShippingServiceOptions : BaseClass
	{
		[IsRequired]
		[JsonProperty("AvailableCarrierWillPickUpOptions")]
		public AvailableCarrierWillPickUpOptionsList AvailableCarrierWillPickUpOptions { get; set; }

		[IsRequired]
		[JsonProperty("AvailableDeliveryExperienceOptions")]
		public AvailableDeliveryExperienceOptionsList AvailableDeliveryExperienceOptions { get; set; }
	}
}
