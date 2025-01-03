namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/notifications/v1/subscriptions/{notificationType}")]
	public class CreateSubscriptionPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateSubscriptionRequest Body { get; set; }

		/// <summary>
		/// The type of notification.   For more information about notification types, refer to [Notification Type
		/// Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
		/// </summary>
		[InPath("notificationType")]
		[IsRequired]
		[JsonProperty("notificationType")]
		public NotificationType NotificationType { get; set; }
	}
}
