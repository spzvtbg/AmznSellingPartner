namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `deleteSubscriptionById` operation.
	/// </summary>
	public class DeleteSubscriptionByIdResponse : BaseClass
	{
		/// <summary>
		/// An unexpected condition occurred during the `deleteSubscriptionById` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
