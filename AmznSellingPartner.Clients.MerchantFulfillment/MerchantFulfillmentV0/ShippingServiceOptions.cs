namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Extra services provided by a carrier.
	/// </summary>
	public class ShippingServiceOptions : BaseClass
	{
		/// <summary>
		/// The delivery confirmation level.
		/// </summary>
		[JsonProperty("DeliveryExperience")]
		[IsRequired]
		public DeliveryExperienceType DeliveryExperience { get; set; } 

		/// <summary>
		/// The declared value of the shipment. The carrier uses this value to determine the amount to
		/// use to insure the shipment. If `DeclaredValue` is greater than the carrier's minimum insurance
		/// amount, the seller is charged for the additional insurance, as determined by the carrier. For
		/// information about optional insurance coverage, refer to Seller Central Help: [UK](https://sellercentral.amazon.co.uk/gp/help/200204080),
		/// [US](https://sellercentral.amazon.com/gp/help/200204080).
		/// </summary>
		[JsonProperty("DeclaredValue")]
		public CurrencyAmount DeclaredValue { get; set; } 

		/// <summary>
		/// When true, the carrier will pick up the package. Note: Scheduled carrier pickup is available
		/// only using Dynamex (US), DPD (UK), and Royal Mail (UK).
		/// </summary>
		[JsonProperty("CarrierWillPickUp")]
		[IsRequired]
		public bool CarrierWillPickUp { get; set; } 

		[JsonProperty("CarrierWillPickUpOption")]
		public CarrierWillPickUpOption CarrierWillPickUpOption { get; set; } 

		/// <summary>
		/// The seller's preferred label format.
		/// </summary>
		[JsonProperty("LabelFormat")]
		public LabelFormat LabelFormat { get; set; } 
	}
}
