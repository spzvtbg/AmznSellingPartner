namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the `getEligibleShipmentServices` operation.
	/// </summary>
	public class GetEligibleShipmentServicesResult : BaseClass
	{
		/// <summary>
		/// A list of shipping services offers.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceList")]
		public ShippingServiceList ShippingServiceList { get; set; }

		[JsonProperty("RejectedShippingServiceList")]
		public RejectedShippingServiceList RejectedShippingServiceList { get; set; }

		[JsonProperty("TemporarilyUnavailableCarrierList")]
		public TemporarilyUnavailableCarrierList TemporarilyUnavailableCarrierList { get; set; }

		[JsonProperty("TermsAndConditionsNotAcceptedCarrierList")]
		public TermsAndConditionsNotAcceptedCarrierList TermsAndConditionsNotAcceptedCarrierList { get; set; }
	}
}
