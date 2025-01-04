namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Info About Linkable Carrier
	/// </summary>
	public class LinkableCarrier : BaseClass
	{
		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; } 

		[JsonProperty("linkableAccountTypes")]
		public LinkableAccountTypeList LinkableAccountTypes { get; set; } 
	}
}
