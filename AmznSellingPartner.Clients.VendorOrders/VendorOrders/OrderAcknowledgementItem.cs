namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Details of the item being acknowledged.
	/// </summary>
	public class OrderAcknowledgementItem : BaseClass
	{
		/// <summary>
		/// Line item sequence number for the item.
		/// </summary>
		[JsonProperty("itemSequenceNumber")]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) of an item.
		/// </summary>
		[JsonProperty("amazonProductIdentifier")]
		public string AmazonProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item. Should be the same as was sent in the purchase order.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// The quantity of this item ordered.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderedQuantity")]
		public ItemQuantity OrderedQuantity { get; set; }

		/// <summary>
		/// The net cost of an item per each or weight unit that must match the cost on the invoice. This is a required fi
		/// ld. If left blank, Amazon systems will reject the file. Price information must not be zero or negative.
		/// </summary>
		[JsonProperty("netCost")]
		public Money NetCost { get; set; }

		/// <summary>
		/// The list price of an item per each or weight unit. Required only if a vendor sells books at list price.
		/// </summary>
		[JsonProperty("listPrice")]
		public Money ListPrice { get; set; }

		/// <summary>
		/// The discount multiplier that should be applied to the price if a vendor sells books with a list price. This is
		/// a multiplier factor to arrive at a final discounted price. A multiplier of .90 would be the factor if a 10% di
		/// count is given.
		/// </summary>
		[JsonProperty("discountMultiplier")]
		public string DiscountMultiplier { get; set; }

		/// <summary>
		/// This is used to indicate acknowledged quantity.
		/// </summary>
		[IsRequired]
		[JsonProperty("itemAcknowledgements")]
		public List<OrderItemAcknowledgement> ItemAcknowledgements { get; set; }
	}
}
