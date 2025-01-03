namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Service Related Info
	/// </summary>
	public class Service : BaseClass
	{
		[IsRequired]
		[JsonProperty("id")]
		public ServiceId Id { get; set; }

		[IsRequired]
		[JsonProperty("name")]
		public ServiceName Name { get; set; }
	}
}
