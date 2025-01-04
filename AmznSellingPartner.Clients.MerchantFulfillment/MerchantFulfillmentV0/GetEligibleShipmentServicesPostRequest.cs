namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/mfn/v0/eligibleShippingServices")]
	public class GetEligibleShipmentServicesPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `GetEligibleShipmentServices` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public GetEligibleShipmentServicesRequest Body { get; set; } 
	}
}
