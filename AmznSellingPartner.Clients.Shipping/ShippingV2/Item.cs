namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// An item in a package.
	/// </summary>
	public class Item : BaseClass
	{
		[JsonProperty("itemValue")]
		public Currency ItemValue { get; set; }

		/// <summary>
		/// The product description of the item.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// A unique identifier for an item provided by the client.
		/// </summary>
		[JsonProperty("itemIdentifier")]
		public string ItemIdentifier { get; set; }

		/// <summary>
		/// The number of units. This value is required.
		/// </summary>
		[IsRequired]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("weight")]
		public Weight Weight { get; set; }

		[JsonProperty("liquidVolume")]
		public LiquidVolume LiquidVolume { get; set; }

		/// <summary>
		/// When true, the item qualifies as hazardous materials (hazmat). Defaults to false.
		/// </summary>
		[JsonProperty("isHazmat")]
		public bool IsHazmat { get; set; }

		[JsonProperty("dangerousGoodsDetails")]
		public DangerousGoodsDetails DangerousGoodsDetails { get; set; }

		/// <summary>
		/// The product type of the item.
		/// </summary>
		[JsonProperty("productType")]
		public string ProductType { get; set; }

		[JsonProperty("invoiceDetails")]
		public InvoiceDetails InvoiceDetails { get; set; }

		/// <summary>
		/// A list of unique serial numbers in an Amazon package that can be used to guarantee non-fraudulent items.
		/// The number of serial numbers in the list must be less than or equal to the quantity of items being shipped.
		/// Only applicable when channel source is Amazon.
		/// </summary>
		[JsonProperty("serialNumbers")]
		public List<string> SerialNumbers { get; set; }

		[JsonProperty("directFulfillmentItemIdentifiers")]
		public DirectFulfillmentItemIdentifiers DirectFulfillmentItemIdentifiers { get; set; }
	}
}
