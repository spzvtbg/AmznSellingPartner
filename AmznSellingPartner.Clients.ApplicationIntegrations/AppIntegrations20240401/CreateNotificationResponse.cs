namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response for the `createNotification` operation.
	/// </summary>
	public class CreateNotificationResponse : BaseClass
	{
		/// <summary>
		/// The unique identifier assigned to each notification.
		/// </summary>
		[JsonProperty("notificationId")]
		public string NotificationId { get; set; } 
	}
}
