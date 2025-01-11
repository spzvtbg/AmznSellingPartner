namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/shipping/v2/unmanifestedShipments")]
	public class AmznGetUnmanifestedShipmentsRequest : BaseHttpRequest
	{
		[InBody("body")]
		[IsRequired]
		public GetUnmanifestedShipmentsRequest Body { get; set; } 

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; } 
	}
}
