namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request for the `deleteNotifications` operation.
	/// </summary>
	public class DeleteNotificationsRequest : BaseClass
	{
		/// <summary>
		/// The unique identifier of the notification template you used to onboard your application.
		/// </summary>
		[JsonProperty("templateId")]
		[IsRequired]
		public string TemplateId { get; set; }

		/// <summary>
		/// The unique identifier that maps each notification status to a reason code.
		/// </summary>
		[JsonProperty("deletionReason")]
		[IsRequired]
		public DeletionReason DeletionReason { get; set; }
	}
}
