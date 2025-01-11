namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/products/fees/v0/listings/{SellerSKU}/feesEstimate")]
	public class AmznGetMyFeesEstimateForSKURequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetMyFeesEstimateRequest Body { get; set; } 

		/// <summary>
		/// Used to identify an item in the given marketplace. SellerSKU is qualified by the seller's SellerId,
		/// which is included with every operation that you submit.
		/// </summary>
		[InPath("SellerSKU")]
		[IsRequired]
		public string SellerSKU { get; set; } 
	}
}
