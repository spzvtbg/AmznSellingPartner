namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `createFulfillmentReturn` operation creates a fulfillment return for items that were fulfilled using the `
	/// reateFulfillmentOrder` operation
	/// For calls to `createFulfillmentReturn`, you must include `ReturnReasonCode` values returned by a previous cal
	/// to the `listReturnReasonCodes` operation
	/// </summary>
	public class CreateFulfillmentReturnRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("items")]
		public CreateReturnItemList Items { get; set; }
	}
}
