namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/products/fees/v0/listings/{SellerSKU}/feesEstimate")]
	public class GetMyFeesEstimateForSKUPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetMyFeesEstimateRequest Body { get; set; }

		/// <summary>
		/// Used to identify an item in the given marketplace. SellerSKU is qualified by the seller's SellerId, which
		/// is included with every operation that you submit.
		/// </summary>
		[InPath("SellerSKU")]
		[IsRequired]
		[JsonProperty("SellerSKU")]
		public string SellerSKU { get; set; }
	}
}
