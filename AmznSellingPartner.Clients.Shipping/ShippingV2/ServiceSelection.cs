namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Service Selection Criteria.
	/// </summary>
	public class ServiceSelection : BaseClass
	{
		[JsonProperty("serviceId")]
		[IsRequired]
		public ServiceIds ServiceId { get; set; } 
	}
}
