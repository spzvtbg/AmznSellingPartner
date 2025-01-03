namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/appIntegrations/2024-04-01/notifications/{notificationId}/feedback")]
	public class RecordActionFeedbackPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A `notificationId` uniquely identifies a notification.
		/// </summary>
		[InPath("notificationId")]
		[IsRequired]
		[JsonProperty("notificationId")]
		public string NotificationId { get; set; }

		/// <summary>
		/// The request body for the `recordActionFeedback` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public RecordActionFeedbackRequest Body { get; set; }
	}
}
