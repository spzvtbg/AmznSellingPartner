namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/products/fees/v0/items/{Asin}/feesEstimate")]
	public class GetMyFeesEstimateForASINPostRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetMyFeesEstimateRequest Body { get; set; }

		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item
		/// </summary>
		[InPath("Asin")]
		[IsRequired]
		[JsonProperty("Asin")]
		public string Asin { get; set; }
	}
}
