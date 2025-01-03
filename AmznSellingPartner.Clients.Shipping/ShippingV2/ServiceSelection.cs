namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Service Selection Criteria.
	/// </summary>
	public class ServiceSelection : BaseClass
	{
		[IsRequired]
		[JsonProperty("serviceId")]
		public ServiceIds ServiceId { get; set; }
	}
}
