namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getDestinations` operation
	/// </summary>
	public class GetDestinationsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getDestinations` operation
		/// </summary>
		[JsonProperty("payload")]
		public DestinationList Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getDestinations` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
