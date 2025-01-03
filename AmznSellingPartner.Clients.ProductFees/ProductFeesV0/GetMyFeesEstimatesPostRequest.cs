namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/products/fees/v0/feesEstimate")]
	public class GetMyFeesEstimatesPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetMyFeesEstimatesRequest Body { get; set; }
	}
}
