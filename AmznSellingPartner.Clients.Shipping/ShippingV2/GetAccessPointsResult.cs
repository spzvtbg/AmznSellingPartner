namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the GetAccessPoints API.
	/// </summary>
	public class GetAccessPointsResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("accessPointsMap")]
		public AccessPointsMap AccessPointsMap { get; set; }
	}
}
