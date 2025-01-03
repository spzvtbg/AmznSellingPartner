namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `createSubscription` operation
	/// </summary>
	public class CreateSubscriptionRequest : BaseClass
	{
		/// <summary>
		/// The version of the payload object to be used in the notification
		/// </summary>
		[IsRequired]
		[JsonProperty("payloadVersion")]
		public string PayloadVersion { get; set; }

		/// <summary>
		/// The identifier for the destination where notifications will be delivered
		/// </summary>
		[IsRequired]
		[JsonProperty("destinationId")]
		public string DestinationId { get; set; }

		[JsonProperty("processingDirective")]
		public ProcessingDirective ProcessingDirective { get; set; }
	}
}
