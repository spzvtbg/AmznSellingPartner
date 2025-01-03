namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Carrier Related Info
	/// </summary>
	public class Carrier : BaseClass
	{
		[IsRequired]
		[JsonProperty("id")]
		public CarrierId Id { get; set; }

		[IsRequired]
		[JsonProperty("name")]
		public CarrierName Name { get; set; }
	}
}
