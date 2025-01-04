namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the GetCarrierAccountsResponse operation.
	/// </summary>
	public class GetCarrierAccountsResponse : BaseClass
	{
		[JsonProperty("activeAccounts")]
		[IsRequired]
		public ActiveAccounts ActiveAccounts { get; set; } 
	}
}
