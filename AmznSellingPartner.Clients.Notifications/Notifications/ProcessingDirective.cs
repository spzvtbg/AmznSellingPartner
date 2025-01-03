namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional information passed to the subscription to control the processing of notifications. For example, you
	/// can use an `eventFilter` to customize your subscription to send notifications for only the specified `marketpl
	/// ceId`s, or select the aggregation time period at which to send notifications (for example: limit to one notifi
	/// ation every five minutes for high frequency notifications). The specific features available vary depending on
	/// he `notificationType`.  This feature is currently only supported by the `ANY_OFFER_CHANGED` and `ORDER_CHANGE`
	/// `notificationType`s.
	/// </summary>
	public class ProcessingDirective : BaseClass
	{
		/// <summary>
		/// A `notificationType` specific filter.
		/// </summary>
		[JsonProperty("eventFilter")]
		public EventFilter EventFilter { get; set; }
	}
}
