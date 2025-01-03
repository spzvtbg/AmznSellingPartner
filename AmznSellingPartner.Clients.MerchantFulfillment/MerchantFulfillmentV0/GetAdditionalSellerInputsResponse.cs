namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema.
	/// </summary>
	public class GetAdditionalSellerInputsResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetAdditionalSellerInputsResult Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
