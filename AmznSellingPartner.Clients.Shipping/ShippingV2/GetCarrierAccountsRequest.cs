namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the GetCarrierAccounts operation.
	/// </summary>
	public class GetCarrierAccountsRequest : BaseClass
	{
		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }
	}
}
