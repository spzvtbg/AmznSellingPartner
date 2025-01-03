namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getFulfillmentPreview` operation
	/// </summary>
	public class GetFulfillmentPreviewResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the `getFulfillmentPreview` operation
		/// </summary>
		[JsonProperty("payload")]
		public GetFulfillmentPreviewResult Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getFulfillmentPreview` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
