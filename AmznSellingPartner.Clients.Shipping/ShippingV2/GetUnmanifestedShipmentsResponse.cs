namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the GetUnmanifestedShipmentsResponse operation.
	/// </summary>
	public class GetUnmanifestedShipmentsResponse : BaseClass
	{
		[JsonProperty("unmanifestedCarrierInformationList")]
		public UnmanifestedCarrierInformationList UnmanifestedCarrierInformationList { get; set; } 
	}
}
