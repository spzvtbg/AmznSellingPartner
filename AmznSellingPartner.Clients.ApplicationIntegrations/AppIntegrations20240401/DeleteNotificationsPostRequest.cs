namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/appIntegrations/2024-04-01/notifications/deletion")]
	public class DeleteNotificationsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `deleteNotifications` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public DeleteNotificationsRequest Body { get; set; }
	}
}
