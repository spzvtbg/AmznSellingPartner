namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A single order item's buyer information.
	/// </summary>
	public class OrderItemBuyerInfo : BaseClass
	{
		/// <summary>
		/// An Amazon-defined order item identifier.
		/// </summary>
		[JsonProperty("OrderItemId")]
		[IsRequired]
		public string OrderItemId { get; set; } 

		/// <summary>
		/// Buyer information for custom orders from the Amazon Custom program.  **Note**: This attribute is only
		/// available for MFN (fulfilled by seller) orders.
		/// </summary>
		[JsonProperty("BuyerCustomizedInfo")]
		public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; } 

		/// <summary>
		/// The gift wrap price of the item.
		/// </summary>
		[JsonProperty("GiftWrapPrice")]
		public Money GiftWrapPrice { get; set; } 

		/// <summary>
		/// The tax on the gift wrap price.
		/// </summary>
		[JsonProperty("GiftWrapTax")]
		public Money GiftWrapTax { get; set; } 

		/// <summary>
		/// A gift message provided by the buyer.  **Note**: This attribute is only available for MFN (fulfilled
		/// by seller) orders.
		/// </summary>
		[JsonProperty("GiftMessageText")]
		public string GiftMessageText { get; set; } 

		/// <summary>
		/// The gift wrap level specified by the buyer.
		/// </summary>
		[JsonProperty("GiftWrapLevel")]
		public string GiftWrapLevel { get; set; } 
	}
}
