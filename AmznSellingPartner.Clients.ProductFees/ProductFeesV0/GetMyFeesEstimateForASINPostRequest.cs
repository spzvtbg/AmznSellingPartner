namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/products/fees/v0/items/{Asin}/feesEstimate")]
	public class GetMyFeesEstimateForASINPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetMyFeesEstimateRequest Body { get; set; } 

		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[InPath("Asin")]
		[IsRequired]
		public string Asin { get; set; } 
	}
}
