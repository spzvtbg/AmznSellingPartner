namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The breakdown of eligibility inventory by feature
	/// </summary>
	public class GetFeatureInventoryResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetFeatureInventoryResult Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getFeatureInventory` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
