namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/products/fees/v0/feesEstimate")]
	public class GetMyFeesEstimatesPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetMyFeesEstimatesRequest Body { get; set; } 
	}
}
