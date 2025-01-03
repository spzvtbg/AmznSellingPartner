namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `listReturnReasonCodes` operation
	/// </summary>
	public class ListReturnReasonCodesResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `listReturnReasonCodes` operation
		/// </summary>
		[JsonProperty("payload")]
		public ListReturnReasonCodesResult Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `listReturnReasonCodes` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
