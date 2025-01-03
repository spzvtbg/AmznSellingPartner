namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Detailed information for an ineligible shipping service offering
	/// </summary>
	public class IneligibleRate : BaseClass
	{
		[IsRequired]
		[JsonProperty("serviceId")]
		public ServiceId ServiceId { get; set; }

		[IsRequired]
		[JsonProperty("serviceName")]
		public ServiceName ServiceName { get; set; }

		[IsRequired]
		[JsonProperty("carrierName")]
		public CarrierName CarrierName { get; set; }

		[IsRequired]
		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; }

		/// <summary>
		/// A list of reasons why a shipping service offering is ineligible
		/// </summary>
		[IsRequired]
		[JsonProperty("ineligibilityReasons")]
		public List<IneligibilityReason> IneligibilityReasons { get; set; }
	}
}
