namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request for the listReturnReasonCodes operation.
	/// </summary>
	public class ListReturnReasonCodesResult : BaseClass
	{
		[JsonProperty("reasonCodeDetails")]
		public ReasonCodeDetailsList ReasonCodeDetails { get; set; } 
	}
}
