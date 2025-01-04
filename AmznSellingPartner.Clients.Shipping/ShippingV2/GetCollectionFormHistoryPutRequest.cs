namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/shipping/v2/collectionForms/history")]
	public class GetCollectionFormHistoryPutRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetCollectionFormHistoryRequest Body { get; set; } 

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; } 
	}
}
