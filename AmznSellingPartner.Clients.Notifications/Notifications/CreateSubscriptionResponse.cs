namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `createSubscription` operation.
	/// </summary>
	public class CreateSubscriptionResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `createSubscription` operation.
		/// </summary>
		[JsonProperty("payload")]
		public Subscription Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `createSubscription` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
