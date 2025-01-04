namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The shipment item information required by a seller to issue a shipment invoice.
	/// </summary>
	public class ShipmentItem : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[JsonProperty("ASIN")]
		public string ASIN { get; set; } 

		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[JsonProperty("SellerSKU")]
		public string SellerSKU { get; set; } 

		/// <summary>
		/// The Amazon-defined identifier for the order item.
		/// </summary>
		[JsonProperty("OrderItemId")]
		public string OrderItemId { get; set; } 

		/// <summary>
		/// The name of the item.
		/// </summary>
		[JsonProperty("Title")]
		public string Title { get; set; } 

		/// <summary>
		/// The number of items ordered.
		/// </summary>
		[JsonProperty("QuantityOrdered")]
		public double QuantityOrdered { get; set; } 

		/// <summary>
		/// The selling price of the item multiplied by the quantity ordered. Note that ItemPrice excludes ShippingPrice
		/// and GiftWrapPrice.
		/// </summary>
		[JsonProperty("ItemPrice")]
		public Money ItemPrice { get; set; } 

		/// <summary>
		/// The shipping price of the item.
		/// </summary>
		[JsonProperty("ShippingPrice")]
		public Money ShippingPrice { get; set; } 

		/// <summary>
		/// The gift wrap price of the item.
		/// </summary>
		[JsonProperty("GiftWrapPrice")]
		public Money GiftWrapPrice { get; set; } 

		/// <summary>
		/// The discount on the shipping price.
		/// </summary>
		[JsonProperty("ShippingDiscount")]
		public Money ShippingDiscount { get; set; } 

		/// <summary>
		/// The total of all promotional discounts in the offer.
		/// </summary>
		[JsonProperty("PromotionDiscount")]
		public Money PromotionDiscount { get; set; } 

		/// <summary>
		/// The list of serial numbers.
		/// </summary>
		[JsonProperty("SerialNumbers")]
		public SerialNumbersList SerialNumbers { get; set; } 
	}
}
