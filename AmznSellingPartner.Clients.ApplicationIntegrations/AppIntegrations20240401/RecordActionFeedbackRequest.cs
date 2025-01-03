namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request for the `recordActionFeedback` operation.
	/// </summary>
	public class RecordActionFeedbackRequest : BaseClass
	{
		/// <summary>
		/// The unique identifier for each notification status.
		/// </summary>
		[IsRequired]
		[JsonProperty("feedbackActionCode")]
		public FeedbackActionCode FeedbackActionCode { get; set; }
	}
}
