namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the `getAdditionalSellerInputs` operation
	/// </summary>
	public class GetAdditionalSellerInputsResult : BaseClass
	{
		[JsonProperty("ShipmentLevelFields")]
		public AdditionalInputsList ShipmentLevelFields { get; set; }

		[JsonProperty("ItemLevelFieldsList")]
		public ItemLevelFieldsList ItemLevelFieldsList { get; set; }
	}
}
