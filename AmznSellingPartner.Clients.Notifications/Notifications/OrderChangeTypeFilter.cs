namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// An event filter to customize your subscription to send notifications for only the specified `orderCh
	/// angeType`.
	/// </summary>
	public class OrderChangeTypeFilter : BaseClass
	{
		[JsonProperty("orderChangeTypes")]
		public OrderChangeTypes OrderChangeTypes { get; set; }
	}
}
