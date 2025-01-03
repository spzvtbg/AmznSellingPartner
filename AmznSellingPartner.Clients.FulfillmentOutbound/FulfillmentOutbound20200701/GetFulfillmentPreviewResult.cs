namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// A list of fulfillment order previews, including estimated shipping weights, estimated shipping fees, and estim
	/// ted ship dates and arrival dates.
	/// </summary>
	public class GetFulfillmentPreviewResult : BaseClass
	{
		[JsonProperty("fulfillmentPreviews")]
		public FulfillmentPreviewList FulfillmentPreviews { get; set; }
	}
}
