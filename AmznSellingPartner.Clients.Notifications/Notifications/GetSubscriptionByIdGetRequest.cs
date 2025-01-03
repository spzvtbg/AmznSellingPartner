namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/notifications/v1/subscriptions/{notificationType}/{subscriptionId}")]
	public class GetSubscriptionByIdGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the subscription that you want to get.
		/// </summary>
		[InPath("subscriptionId")]
		[IsRequired]
		[JsonProperty("subscriptionId")]
		public string SubscriptionId { get; set; }

		/// <summary>
		/// The type of notification.   For more information about notification types, refer to [Notification Type Values]
		/// https://developer-docs.amazon.com/sp-api/docs/notification-type-values).
		/// </summary>
		[InPath("notificationType")]
		[IsRequired]
		[JsonProperty("notificationType")]
		public NotificationType NotificationType { get; set; }
	}
}
