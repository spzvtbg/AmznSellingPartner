namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request for the `createNotification` operation
	/// </summary>
	public class CreateNotificationRequest : BaseClass
	{
		/// <summary>
		/// The unique identifier of the notification template you used to onboard your application
		/// </summary>
		[IsRequired]
		[JsonProperty("templateId")]
		public string TemplateId { get; set; }

		/// <summary>
		/// The parameters specified in the template you used to onboard your application
		/// </summary>
		[IsRequired]
		[JsonProperty("notificationParameters")]
		public NotificationParameters NotificationParameters { get; set; }

		/// <summary>
		/// An encrypted marketplace identifier for the posted notification
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }
	}
}
