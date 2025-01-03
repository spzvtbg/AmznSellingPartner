namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// A collection of supported value-added services.
	/// </summary>
	public class ValueAddedServiceDetails : BaseClass
	{
		[JsonProperty("collectOnDelivery")]
		public CollectOnDelivery CollectOnDelivery { get; set; }
	}
}
