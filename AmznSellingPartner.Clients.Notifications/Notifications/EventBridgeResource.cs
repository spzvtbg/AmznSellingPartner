namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The Amazon EventBridge destination.
	/// </summary>
	public class EventBridgeResource : BaseClass
	{
		/// <summary>
		/// The name of the partner event source associated with the destination.
		/// </summary>
		[IsRequired]
		[MaxLength(256)]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The AWS region in which you receive the notifications. For AWS regions that are supported in Amazon EventBridge,
		/// refer to [Amazon EventBridge endpoints and quotas](https://docs.aws.amazon.com/general/latest/gr/ev.
		/// html).
		/// </summary>
		[IsRequired]
		[JsonProperty("region")]
		public string Region { get; set; }

		/// <summary>
		/// The identifier for the AWS account that is responsible for charges related to receiving notification
		/// s.
		/// </summary>
		[IsRequired]
		[JsonProperty("accountId")]
		public string AccountId { get; set; }
	}
}
