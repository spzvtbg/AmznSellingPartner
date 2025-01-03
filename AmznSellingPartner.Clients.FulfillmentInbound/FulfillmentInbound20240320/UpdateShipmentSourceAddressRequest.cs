namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `UpdateShipmentSourceAddress` request.
	/// </summary>
	public class UpdateShipmentSourceAddressRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("address")]
		public AddressInput Address { get; set; }
	}
}
