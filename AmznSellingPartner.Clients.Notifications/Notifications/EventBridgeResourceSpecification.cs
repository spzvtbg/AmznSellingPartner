namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The information required to create an Amazon EventBridge destination.
	/// </summary>
	public class EventBridgeResourceSpecification : BaseClass
	{
		/// <summary>
		/// The AWS region in which you will be receiving the notifications.
		/// </summary>
		[IsRequired]
		[JsonProperty("region")]
		public string Region { get; set; }

		/// <summary>
		/// The identifier for the AWS account that is responsible for charges related to receiving notifications.
		/// </summary>
		[IsRequired]
		[JsonProperty("accountId")]
		public string AccountId { get; set; }
	}
}
