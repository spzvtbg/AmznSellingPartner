namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents a product with the SKU details and the corresponding quantity.
	/// </summary>
	public class ProductQuantity : BaseClass
	{
		/// <summary>
		/// Attributes for this instance of the product. For example, already-prepped, or other attributes that distinguish
		/// the product beyond the SKU.
		/// </summary>
		[JsonProperty("attributes")]
		public List<ProductAttribute> Attributes { get; set; } 

		/// <summary>
		/// Product quantity.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		public int Quantity { get; set; } 

		/// <summary>
		/// The seller or merchant SKU.
		/// </summary>
		[JsonProperty("sku")]
		[IsRequired]
		public string Sku { get; set; } 

		/// <summary>
		/// The expiration date for the SKU. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; } 

		/// <summary>
		/// Preparation details of a product which contains the prep category, prep owner and the label owner. If
		/// not passed while creating an inbound order, NO_PREP will be used on the product by-default. Prep instructions
		/// will be generated based on the category passed
		/// </summary>
		[JsonProperty("prepDetails")]
		public PrepDetails PrepDetails { get; set; } 
	}
}
