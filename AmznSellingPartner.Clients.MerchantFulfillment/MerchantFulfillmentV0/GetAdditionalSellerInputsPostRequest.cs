namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/mfn/v0/additionalSellerInputs")]
	public class GetAdditionalSellerInputsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `GetAdditionalSellerInputs` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public GetAdditionalSellerInputsRequest Body { get; set; } 
	}
}
