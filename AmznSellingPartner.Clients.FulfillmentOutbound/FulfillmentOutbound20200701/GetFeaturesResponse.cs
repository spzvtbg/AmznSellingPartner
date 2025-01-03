namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getFeatures` operation.
	/// </summary>
	public class GetFeaturesResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetFeaturesResult Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
