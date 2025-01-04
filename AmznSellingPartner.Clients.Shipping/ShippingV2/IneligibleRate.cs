namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Detailed information for an ineligible shipping service offering.
	/// </summary>
	public class IneligibleRate : BaseClass
	{
		[JsonProperty("serviceId")]
		[IsRequired]
		public ServiceId ServiceId { get; set; }

		[JsonProperty("serviceName")]
		[IsRequired]
		public ServiceName ServiceName { get; set; }

		[JsonProperty("carrierName")]
		[IsRequired]
		public CarrierName CarrierName { get; set; }

		[JsonProperty("carrierId")]
		[IsRequired]
		public CarrierId CarrierId { get; set; }

		/// <summary>
		/// A list of reasons why a shipping service offering is ineligible.
		/// </summary>
		[JsonProperty("ineligibilityReasons")]
		[IsRequired]
		public List<IneligibilityReason> IneligibilityReasons { get; set; }
	}
}
