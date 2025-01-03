namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getSubscription` operation.
	/// </summary>
	public class GetSubscriptionResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getSubscription` operation.
		/// </summary>
		[JsonProperty("payload")]
		public Subscription Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getSubscription` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
