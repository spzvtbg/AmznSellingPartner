namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// Describes a messaging action that can be taken for an order. Provides a JSON Hypertext Application
	/// Language (HAL) link to the JSON schema document that describes the expected input.
	/// </summary>
	public class GetMessagingActionResponse : BaseClass
	{
		/// <summary>
		/// The links response that is associated with the messaging action.
		/// </summary>
		[JsonProperty("_links")]
		public Links Links { get; set; } 

		/// <summary>
		/// The embedded response associated with the messaging action.
		/// </summary>
		[JsonProperty("_embedded")]
		public Embedded Embedded { get; set; } 

		[JsonProperty("payload")]
		public MessagingAction Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
