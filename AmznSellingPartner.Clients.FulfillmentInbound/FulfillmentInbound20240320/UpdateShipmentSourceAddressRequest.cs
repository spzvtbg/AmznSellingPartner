namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `UpdateShipmentSourceAddress` request.
	/// </summary>
	public class UpdateShipmentSourceAddressRequest : BaseClass
	{
		[JsonProperty("address")]
		[IsRequired]
		public AddressInput Address { get; set; } 
	}
}
