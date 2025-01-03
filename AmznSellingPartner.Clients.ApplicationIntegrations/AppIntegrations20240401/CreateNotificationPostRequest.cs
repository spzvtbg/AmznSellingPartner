namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/appIntegrations/2024-04-01/notifications")]
	public class CreateNotificationPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body for the `createNotification` operation
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateNotificationRequest Body { get; set; }
	}
}
