namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// UnmanifestedCarrierInformation like carrierId CarrierName and Location
	/// </summary>
	public class UnmanifestedCarrierInformation : BaseClass
	{
		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; }

		[JsonProperty("carrierName")]
		public CarrierName CarrierName { get; set; }

		[JsonProperty("unmanifestedShipmentLocationList")]
		public UnmanifestedShipmentLocationList UnmanifestedShipmentLocationList { get; set; }
	}
}
