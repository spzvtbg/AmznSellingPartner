namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `createFulfillmentReturn` operation creates a fulfillment return for items that were fulfilled
	/// using the `createFulfillmentOrder` operation. For calls to `createFulfillmentReturn`, you must
	/// include `ReturnReasonCode` values returned by a previous call to the `listReturnReasonCodes`
	/// operation.
	/// </summary>
	public class CreateFulfillmentReturnRequest : BaseClass
	{
		[JsonProperty("items")]
		[IsRequired]
		public CreateReturnItemList Items { get; set; } 
	}
}
