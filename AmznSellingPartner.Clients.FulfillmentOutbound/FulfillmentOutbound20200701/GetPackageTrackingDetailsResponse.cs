namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getPackageTrackingDetails` operation.
	/// </summary>
	public class GetPackageTrackingDetailsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getPackageTrackingDetails` operation.
		/// </summary>
		[JsonProperty("payload")]
		public PackageTrackingDetails Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getPackageTrackingDetails` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
