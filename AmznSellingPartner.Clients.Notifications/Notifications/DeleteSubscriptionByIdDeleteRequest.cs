namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpDelete("/notifications/v1/subscriptions/{notificationType}/{subscriptionId}")]
	public class DeleteSubscriptionByIdDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the subscription that you want to delete.
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
