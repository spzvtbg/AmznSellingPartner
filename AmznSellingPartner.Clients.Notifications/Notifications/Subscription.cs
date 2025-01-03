namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the subscription
	/// </summary>
	public class Subscription : BaseClass
	{
		/// <summary>
		/// The subscription identifier generated when the subscription is created
		/// </summary>
		[IsRequired]
		[JsonProperty("subscriptionId")]
		public string SubscriptionId { get; set; }

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
