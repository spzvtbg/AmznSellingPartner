namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPost("/solicitations/v1/orders/{amazonOrderId}/solicitations/productReviewAndSellerFeedback")]
	public class CreateProductReviewAndSellerFeedbackSolicitationPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon order identifier. This specifies the order for which a solicitation is sent.
		/// </summary>
		[InPath("amazonOrderId")]
		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace
		/// can be specified.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
