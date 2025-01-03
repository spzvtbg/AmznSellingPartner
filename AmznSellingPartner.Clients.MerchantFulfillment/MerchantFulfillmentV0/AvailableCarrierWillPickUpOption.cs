namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Indicates whether the carrier will pick up the package, and what fee is charged, if any
	/// </summary>
	public class AvailableCarrierWillPickUpOption : BaseClass
	{
		[IsRequired]
		[JsonProperty("CarrierWillPickUpOption")]
		public CarrierWillPickUpOption CarrierWillPickUpOption { get; set; }

		/// <summary>
		/// The fee charged
		/// </summary>
		[IsRequired]
		[JsonProperty("Charge")]
		public CurrencyAmount Charge { get; set; }
	}
}
