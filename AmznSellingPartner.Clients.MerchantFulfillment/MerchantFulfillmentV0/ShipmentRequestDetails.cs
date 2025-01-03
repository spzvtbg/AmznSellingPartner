namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment information required for requesting shipping service offers or for creating a shipment.
	/// </summary>
	public class ShipmentRequestDetails : BaseClass
	{
		/// <summary>
		/// An Amazon-defined order identifier in 3-7-7 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("AmazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		/// <summary>
		/// A seller-defined order identifier.
		/// </summary>
		[JsonProperty("SellerOrderId")]
		public SellerOrderId SellerOrderId { get; set; }

		[IsRequired]
		[JsonProperty("ItemList")]
		public ItemList ItemList { get; set; }

		/// <summary>
		/// The address of the sender.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShipFromAddress")]
		public Address ShipFromAddress { get; set; }

		/// <summary>
		/// The package dimensions.
		/// </summary>
		[IsRequired]
		[JsonProperty("PackageDimensions")]
		public PackageDimensions PackageDimensions { get; set; }

		/// <summary>
		/// The package weight.
		/// </summary>
		[IsRequired]
		[JsonProperty("Weight")]
		public Weight Weight { get; set; }

		/// <summary>
		/// The date by which the package must arrive to keep the promise to the customer, in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format. If `MustArriveByDate` is specified, only shipping service offers that can be delivered
		/// by that date are returned.
		/// </summary>
		[JsonProperty("MustArriveByDate")]
		public Timestamp MustArriveByDate { get; set; }

		/// <summary>
		/// When used in a request, this is the date and time that the seller wants to ship the package. When used
		/// in a response, this is the date and time that the package can be shipped by the indicated method.
		/// </summary>
		[JsonProperty("ShipDate")]
		public Timestamp ShipDate { get; set; }

		/// <summary>
		/// Extra services offered by the carrier.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceOptions")]
		public ShippingServiceOptions ShippingServiceOptions { get; set; }

		/// <summary>
		/// Label customization options.
		/// </summary>
		[JsonProperty("LabelCustomization")]
		public LabelCustomization LabelCustomization { get; set; }
	}
}
