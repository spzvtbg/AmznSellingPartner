namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the GetUnmanifestedShipmentsRequest operation
	/// </summary>
	public class GetUnmanifestedShipmentsRequest : BaseClass
	{
		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }
	}
}
