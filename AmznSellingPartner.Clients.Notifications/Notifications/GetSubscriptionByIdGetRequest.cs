namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/notifications/v1/subscriptions/{notificationType}/{subscriptionId}")]
	public class GetSubscriptionByIdGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the subscription that you want to get.
		/// </summary>
		[InPath("subscriptionId")]
		[IsRequired]
		public string SubscriptionId { get; set; }

		/// <summary>
		/// The type of notification.   For more information about notification types, refer to [Notification Type
		/// Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
		/// </summary>
		[InPath("notificationType")]
		[IsRequired]
		public NotificationType NotificationType { get; set; }
	}
}
