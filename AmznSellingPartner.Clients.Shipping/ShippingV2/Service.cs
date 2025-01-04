namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Service Related Info
	/// </summary>
	public class Service : BaseClass
	{
		[JsonProperty("id")]
		[IsRequired]
		public ServiceId Id { get; set; }

		[JsonProperty("name")]
		[IsRequired]
		public ServiceName Name { get; set; }
	}
}
