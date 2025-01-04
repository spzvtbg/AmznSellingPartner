namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/appIntegrations/2024-04-01/notifications/deletion")]
	public class DeleteNotificationsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `deleteNotifications` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public DeleteNotificationsRequest Body { get; set; }
	}
}
