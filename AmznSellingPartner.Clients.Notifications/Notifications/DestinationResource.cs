namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The destination resource types
	/// </summary>
	public class DestinationResource : BaseClass
	{
		/// <summary>
		/// An Amazon Simple Queue Service (SQS) queue destination
		/// </summary>
		[JsonProperty("sqs")]
		public SqsResource Sqs { get; set; }

		/// <summary>
		/// An Amazon EventBridge destination
		/// </summary>
		[JsonProperty("eventBridge")]
		public EventBridgeResource EventBridge { get; set; }
	}
}
