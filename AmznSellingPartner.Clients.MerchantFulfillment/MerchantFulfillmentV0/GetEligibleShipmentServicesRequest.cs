namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema.
	/// </summary>
	public class GetEligibleShipmentServicesRequest : BaseClass
	{
		/// <summary>
		/// Shipment information required for requesting shipping service offers.
		/// </summary>
		[JsonProperty("ShipmentRequestDetails")]
		[IsRequired]
		public ShipmentRequestDetails ShipmentRequestDetails { get; set; } 

		[JsonProperty("ShippingOfferingFilter")]
		public ShippingOfferingFilter ShippingOfferingFilter { get; set; } 
	}
}
