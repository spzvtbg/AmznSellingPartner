namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/notifications/v1/subscriptions/{notificationType}")]
	public class GetSubscriptionGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The type of notification.   For more information about notification types, refer to [Notification Type
		/// Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
		/// </summary>
		[InPath("notificationType")]
		[IsRequired]
		[JsonProperty("notificationType")]
		public NotificationType NotificationType { get; set; }

		/// <summary>
		/// The version of the payload object to be used in the notification.
		/// </summary>
		[InQuery("payloadVersion")]
		[JsonProperty("payloadVersion")]
		public string PayloadVersion { get; set; }
	}
}
