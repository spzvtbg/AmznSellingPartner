namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/appIntegrations/2024-04-01/notifications/{notificationId}/feedback")]
	public class RecordActionFeedbackPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A `notificationId` uniquely identifies a notification.
		/// </summary>
		[InPath("notificationId")]
		[IsRequired]
		public string NotificationId { get; set; }

		/// <summary>
		/// The request body for the `recordActionFeedback` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public RecordActionFeedbackRequest Body { get; set; }
	}
}
