namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about a rejected shipping service
	/// </summary>
	public class RejectedShippingService : BaseClass
	{
		/// <summary>
		/// The rejected shipping carrier name. For example, USPS.
		/// </summary>
		[IsRequired]
		[JsonProperty("CarrierName")]
		public string CarrierName { get; set; }

		/// <summary>
		/// The rejected shipping service localized name. For example, FedEx Standard Overnight.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceName")]
		public string ShippingServiceName { get; set; }

		/// <summary>
		/// The rejected shipping service identifier. For example, `FEDEX_PTP_STANDARD_OVERNIGHT`.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceId")]
		public ShippingServiceIdentifier ShippingServiceId { get; set; }

		/// <summary>
		/// A reason code meant to be consumed programatically. For example, `CARRIER_CANNOT_SHIP_TO_POBOX`.
		/// </summary>
		[IsRequired]
		[JsonProperty("RejectionReasonCode")]
		public string RejectionReasonCode { get; set; }

		/// <summary>
		/// A localized human readable description of the rejected reason.
		/// </summary>
		[JsonProperty("RejectionReasonMessage")]
		public string RejectionReasonMessage { get; set; }
	}
}
