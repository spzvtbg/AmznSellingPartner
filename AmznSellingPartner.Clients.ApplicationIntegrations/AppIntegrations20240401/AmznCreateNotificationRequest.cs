namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/appIntegrations/2024-04-01/notifications")]
	public class AmznCreateNotificationRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `createNotification` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateNotificationRequest Body { get; set; } 
	}
}
