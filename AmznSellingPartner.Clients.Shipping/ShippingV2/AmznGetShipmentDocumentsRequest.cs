namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/shipping/v2/shipments/{shipmentId}/documents")]
	public class AmznGetShipmentDocumentsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The shipment identifier originally returned by the purchaseShipment operation.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		public string ShipmentId { get; set; } 

		/// <summary>
		/// The package client reference identifier originally provided in the request body parameter for
		/// the getRates operation.
		/// </summary>
		[InQuery("packageClientReferenceId")]
		[IsRequired]
		public string PackageClientReferenceId { get; set; } 

		/// <summary>
		/// The file format of the document. Must be one of the supported formats returned by the getRates
		/// operation.
		/// </summary>
		[InQuery("format")]
		public string Format { get; set; } 

		/// <summary>
		/// The resolution of the document (for example, 300 means 300 dots per inch). Must be one of the
		/// supported resolutions returned in the response to the getRates operation.
		/// </summary>
		[InQuery("dpi")]
		public double Dpi { get; set; } 

		/// <summary>
		/// Amazon shipping business to assume for this request. The default is AmazonShipping_UK.
		/// </summary>
		[InHeader("x-amzn-shipping-business-id")]
		public XAmznShippingBusinessId XAmznShippingBusinessId { get; set; } 
	}
}
