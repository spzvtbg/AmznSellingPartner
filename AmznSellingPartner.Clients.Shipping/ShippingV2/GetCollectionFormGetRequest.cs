namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/shipping/v2/collectionForms/{collectionFormId}")]
	public class GetCollectionFormGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// collection form Id to reprint a collection.
		/// </summary>
		[InPath("collectionFormId")]
		[IsRequired]
		[JsonProperty("collectionFormId")]
		public string CollectionFormId { get; set; }

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		[JsonProperty("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; }
	}
}
