namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The information required to create a destination resource. Applications should use one resource type
	/// (sqs or eventBridge) per destination.
	/// </summary>
	public class DestinationResourceSpecification : BaseClass
	{
		/// <summary>
		/// The information required to create an Amazon Simple Queue Service (SQS) queue destination.
		/// </summary>
		[JsonProperty("sqs")]
		public SqsResource Sqs { get; set; }

		/// <summary>
		/// The information required to create an Amazon EventBridge destination.
		/// </summary>
		[JsonProperty("eventBridge")]
		public EventBridgeResourceSpecification EventBridge { get; set; }
	}
}
