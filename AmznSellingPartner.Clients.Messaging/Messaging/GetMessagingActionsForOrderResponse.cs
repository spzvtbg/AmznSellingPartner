namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getMessagingActionsForOrder` operation
	/// </summary>
	public class GetMessagingActionsForOrderResponse : BaseClass
	{
		/// <summary>
		/// The links response that is associated with the specified `amazonOrderId`
		/// </summary>
		[JsonProperty("_links")]
		public Links Links { get; set; }

		/// <summary>
		/// The messaging actions response that is associated with the specified `amazonOrderId`
		/// </summary>
		[JsonProperty("_embedded")]
		public Embedded Embedded { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
