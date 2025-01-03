namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The amount to collect on delivery
	/// </summary>
	public class CollectOnDelivery : BaseClass
	{
		[IsRequired]
		[JsonProperty("amount")]
		public Currency Amount { get; set; }
	}
}
