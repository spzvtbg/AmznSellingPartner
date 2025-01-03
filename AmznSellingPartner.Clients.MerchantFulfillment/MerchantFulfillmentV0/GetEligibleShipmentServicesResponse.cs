namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema.
	/// </summary>
	public class GetEligibleShipmentServicesResponse : BaseClass
	{
		[JsonProperty("payload")]
		public GetEligibleShipmentServicesResult Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during this operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
