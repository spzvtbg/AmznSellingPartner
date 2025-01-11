namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A `notificationType` specific filter. This object contains all of the currently available filters
	/// and properties that you can use to define a `notificationType` specific filter.
	/// </summary>
	public class EventFilter : BaseClass
	{
		/// <summary>
		/// An `eventFilterType` value that is supported by the specific `notificationType`. This is used
		/// by the subscription service to determine the type of event filter. Refer to [Notification Type
		/// Values](https://developer-docs.amazon.com/sp-api/docs/notification-type-values) to determine
		/// if an `eventFilterType` is supported.
		/// </summary>
		[JsonProperty("eventFilterType")]
		[IsRequired]
		public EventFilterType EventFilterType { get; set; } 
	}
}
