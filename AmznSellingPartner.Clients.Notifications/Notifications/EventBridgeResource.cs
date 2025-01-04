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
		[JsonProperty("name")]
		[IsRequired]
		[MaxLength(256)]
		public string Name { get; set; } 

		/// <summary>
		/// The AWS region in which you receive the notifications. For AWS regions that are supported in Amazon EventBridge,
		/// refer to [Amazon EventBridge endpoints and quotas](https://docs.aws.amazon.com/general/latest/gr/ev.
		/// html).
		/// </summary>
		[JsonProperty("region")]
		[IsRequired]
		public string Region { get; set; } 

		/// <summary>
		/// The identifier for the AWS account that is responsible for charges related to receiving notification
		/// s.
		/// </summary>
		[JsonProperty("accountId")]
		[IsRequired]
		public string AccountId { get; set; } 
	}
}
