namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getFeatureSKU` operation.
	/// </summary>
	public class GetFeatureSkuResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetFeatureSkuResult Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
