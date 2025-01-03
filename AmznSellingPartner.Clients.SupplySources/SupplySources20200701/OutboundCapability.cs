namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The outbound capability of a supply source
	/// </summary>
	public class OutboundCapability : BaseClass
	{
		[JsonProperty("isSupported")]
		public bool IsSupported { get; set; }

		[JsonProperty("operationalConfiguration")]
		public OperationalConfiguration OperationalConfiguration { get; set; }

		[JsonProperty("returnLocation")]
		public ReturnLocation ReturnLocation { get; set; }

		[JsonProperty("deliveryChannel")]
		public DeliveryChannel DeliveryChannel { get; set; }

		[JsonProperty("pickupChannel")]
		public PickupChannel PickupChannel { get; set; }
	}
}
