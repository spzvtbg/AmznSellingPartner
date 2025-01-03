namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/mfn/v0/eligibleShippingServices")]
	public class GetEligibleShipmentServicesPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `GetEligibleShipmentServices` operation
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetEligibleShipmentServicesRequest Body { get; set; }
	}
}
