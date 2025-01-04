namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The result for the createFulfillmentReturn operation.
	/// </summary>
	public class CreateFulfillmentReturnResult : BaseClass
	{
		[JsonProperty("returnItems")]
		public ReturnItemList ReturnItems { get; set; } 

		[JsonProperty("invalidReturnItems")]
		public InvalidReturnItemList InvalidReturnItems { get; set; } 

		[JsonProperty("returnAuthorizations")]
		public ReturnAuthorizationList ReturnAuthorizations { get; set; } 
	}
}
