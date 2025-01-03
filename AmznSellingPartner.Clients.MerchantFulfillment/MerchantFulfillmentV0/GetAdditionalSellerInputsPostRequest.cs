namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/mfn/v0/additionalSellerInputs")]
	public class GetAdditionalSellerInputsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `GetAdditionalSellerInputs` operation
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetAdditionalSellerInputsRequest Body { get; set; }
	}
}
