namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/notifications/v1/subscriptions/{notificationType}")]
	public class CreateSubscriptionPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public CreateSubscriptionRequest Body { get; set; } 

		/// <summary>
		/// The type of notification.   For more information about notification types, refer to [Notification Type
		/// Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
		/// </summary>
		[InPath("notificationType")]
		[IsRequired]
		public NotificationType NotificationType { get; set; } 
	}
}
